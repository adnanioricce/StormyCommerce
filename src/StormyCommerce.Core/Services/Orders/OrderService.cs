using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Services.Orders
{
    //TODO: Can be a good Idea create specific Repositories for some domain entities, in this case for example, We have to add a Microsoft.EntityFrameworkCore(GetOrderById Method)
    public class OrderService : IOrderService
    {
        private readonly IStormyRepository<StormyOrder> _orderRepository;
        private readonly IStormyRepository<OrderHistory> _orderHistoryRepository;     
        private readonly IShippingService _shippingService;
        public OrderService(IStormyRepository<StormyOrder> orderRepository
            ,IStormyRepository<OrderHistory> orderHistoryRepository
            ,IShippingService shippingService)
        {
            _orderRepository = orderRepository;
            _orderHistoryRepository = orderHistoryRepository;
            _shippingService = shippingService;
            // _orderRepository.
        }
        public async Task<StormyOrder> PrepareOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }
        public async Task<Result<OrderDto>> CancelOrderAsync(long id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null) return new Result<OrderDto>(null, false, "order don't exist");

            order.Status = OrderStatus.Canceled;            
            order.LastModified = DateTimeOffset.UtcNow;
            order.Items.ForEach(item =>
            {
                item.Product.UnitsInStock += item.Quantity;
                item.Product.UnitsOnOrder -= item.Quantity;
            });
            //#warning Pay attention! Be double careful when editing orders.
            await _orderRepository.UpdateAsync(order);
            return new Result<OrderDto>(order.ToOrderDto(), true, "no error");
        }

        //TODO:#warning Remember to edit the StormyProducts(items) on the Controller to sync the UnitsInStock
        public async Task<Result<OrderDto>> CreateOrderAsync(StormyOrder entry)
        {
            if (entry == null)
                return new Result<OrderDto>(entry.ToOrderDto(), false, "We need valid info to create a order,order data don't have any data");
            if (entry.Items == null)
                return new Result<OrderDto>(entry.ToOrderDto(), false, "You have no items to create a order");                                                            
            var shipment = _shippingService.CalculateShipmentDimensions(entry);            
            entry.Shipment = shipment;
            entry.Items.ForEach(o => {
                o.Product.UnitsInStock -= o.Quantity; 
                o.Product.UnitsOnOrder += o.Quantity;                                
            });
            await _orderRepository.AddAsync(entry);   
                                
            return Result.Ok<OrderDto>(entry.ToOrderDto());
        }

        //! If you don't do this right, a order could for example,have your price changed easily
        //TODO:Change the result fail return type, try to encapsulate a exception and return it with the object
        public async Task<Result> EditOrderAsync(long id, StormyOrder entity)
        {
            var _entity = await _orderRepository.GetByIdAsync(id);
            if (_entity == null) return Result.Fail("Entity don't exist");                    
            await _orderRepository.UpdateAsync(entity);
            var orderHistory = new OrderHistory { 
                StormyOrderId = _entity.Id,
                Order = _entity,
                CurrentStatus = entity.Status,
                OldStatus = _entity.Status,
                CreatedById = _entity.StormyCustomerId,
                CreatedBy = _entity.Customer
            };
            await _orderHistoryRepository.AddAsync(orderHistory);
            return Result.Ok();
        }
        public async Task<Result<OrderDto>> GetOrderByUniqueIdAsync(Guid uniqueId)
        {
            _orderRepository.Table
            .Include(order => order.Items)            
            .Include(order => order.Payment)
            .Include(order => order.Shipment); 

            var result = await _orderRepository.Table
            .Where(o => o.OrderUniqueKey.ToString().Equals(uniqueId.ToString()))
            .FirstOrDefaultAsync();
            return new Result<OrderDto>(result.ToOrderDto(),true,"No error");
        }
        public async Task<Result<OrderDto>> GetOrderByIdAsync(long id)
        {
            _orderRepository.Table
                .Include(order => order.Items)
                .Include(order => order.Shipment)                
                .Include(order => order.Customer);

            var entity = await _orderRepository.GetByIdAsync(id);

            if (entity == null)
                return new Result<OrderDto>(null, false, "order don't exists");

            var result = entity.ToOrderDto();
            return new Result<OrderDto>(result, true, "no error");
        }

        //This will take some time, First I need to keep track of the changes on the order
        public Task<OrderHistoryDto> GetOrderHistoryAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result<IList<StormyOrder>>> GetOrdersAsync()
        {
            return new Result<IList<StormyOrder>>(await _orderRepository.GetAllAsync(), true, "no error");
        }

        public Task<Result> EditOrderAsync(Guid uniqueId, StormyOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
