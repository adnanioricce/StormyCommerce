using Microsoft.EntityFrameworkCore;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Shipments.Interfaces;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Orders.Services
{
    //TODO: Can be a good Idea create specific Repositories for some domain entities, in this case for example, We have to add a Microsoft.EntityFrameworkCore(GetOrderById Method)
    public class OrderService : IOrderService
    {
        private readonly IStormyRepository<Order> _orderRepository;
        private readonly IStormyRepository<OrderHistory> _orderHistoryRepository;
        private readonly IProductService _productService;
        private readonly IShippingService _shippingService;
        public OrderService(IStormyRepository<Order> orderRepository
            ,IStormyRepository<OrderHistory> orderHistoryRepository
            ,IProductService productService
            ,IShippingService shippingService)
        {
            _orderRepository = orderRepository;
            _orderHistoryRepository = orderHistoryRepository;
            _productService = productService;
            _shippingService = shippingService;
           
        }        
        public async Task<Result<OrderDto>> CancelOrderAsync(long id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order is null) return Result<OrderDto>.Fail("order don't exist",new OrderDto());

            order.OrderStatus = OrderStatus.Canceled;            
            order.LatestUpdatedOn = DateTimeOffset.UtcNow;
            foreach (var item in order.OrderItems)            
            {
                item.Product.UnitsInStock += item.Quantity;
                item.Product.UnitsOnOrder -= item.Quantity;
            };
            await _productService.UpdateProductsAsync(order.OrderItems.Select(i => i.Product).ToList());
            //#warning Pay attention! Be double careful when editing orders.            
            return Result<OrderDto>.Ok(new OrderDto(order));
        }

        //TODO:#warning Remember to edit the StormyProducts(items) on the Controller to sync the UnitsInStock
        public async Task<Result<OrderDto>> CreateOrderAsync(Order entry)
        {
            if (entry == null)
                return Result<object>.Fail("We need valid info to create a order,order data don't have any data",new OrderDto(entry));
            if (entry.OrderItems == null)
                return Result.Fail("You have no items to create a order", new OrderDto(entry));                                                            
            //var shipment = _shippingService.CalculateShipmentDimensions(entry);            
            //entry.Shipment = shipment;            
            await _orderRepository.AddAsync(entry);
            foreach (var item in entry.OrderItems)
            {
                item.Product.UnitsInStock -= item.Quantity;
                item.Product.UnitsOnOrder += item.Quantity;
            }
            await _productService.UpdateProductsAsync(entry.OrderItems.Select(i => i.Product).ToList());
            //await _orderRepository.UpdateAsync(entry);
            return Result.Ok<OrderDto>(new OrderDto(entry));
        }

        //! If you don't do this right, a order could for example,have your price changed easily
        //TODO:Change the result fail return type, try to encapsulate a exception and return it with the object
        public async Task<Result> EditOrderAsync(long id, Order entity)
        {
            var _entity = await _orderRepository.GetByIdAsync(id);
            if (_entity == null) return Result.Fail("Entity don't exist");                    
            await _orderRepository.UpdateAsync(entity);
            var orderHistory = new OrderHistory { 
                OrderId = _entity.Id,
                Order = _entity,
                NewStatus = entity.OrderStatus,
                OldStatus = _entity.OrderStatus,
                CreatedById = _entity.CreatedById,
                CreatedBy = _entity.Customer
            };
            await _orderHistoryRepository.AddAsync(orderHistory);
            return Result.Ok();
        }
        public async Task<Result<OrderDto>> GetOrderByUniqueIdAsync(Guid uniqueId)
        {
            _orderRepository.Query()
               .Include(order => order.OrderItems)               
               .Include(order => order.Customer)
               .Load();
            _orderRepository.Query()
            .Include(order => order.OrderItems);                                    

            var result = await _orderRepository.Query()
            .Where(o => o.OrderUniqueKey.ToString().Equals(uniqueId.ToString()))
            .FirstOrDefaultAsync();
            return Result.Ok<OrderDto>(new OrderDto(result));
        }
        public async Task<Result<OrderDto>> GetOrderByIdAsync(long id)
        {            
            var entity = await _orderRepository.GetByIdAsync(id);

            if (entity == null) return Result.Fail<OrderDto>($"don't was possible to find order with id {id}",new OrderDto());                

            var result = new OrderDto(entity);
            return Result<OrderDto>.Ok(result);
        }

        //This will take some time, First I need to keep track of the changes on the order
        public Task<OrderHistoryDto> GetOrderHistoryAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result<IList<Order>>> GetOrdersAsync()
        {
            return Result<IList<Order>>.Ok(await _orderRepository.GetAllAsync());
        }

        public Task<Result> EditOrderAsync(Guid uniqueId, Order entity)
        {
            throw new NotImplementedException();
        }        

        public async Task<List<OrderDto>> GetAllOrdersFromCustomer(long customerId)
        {
            return await _orderRepository.Query()
                .Where(c => c.CreatedById == customerId)
                .Select(o => new OrderDto(o))
                .ToListAsync();
        }
    }
}
