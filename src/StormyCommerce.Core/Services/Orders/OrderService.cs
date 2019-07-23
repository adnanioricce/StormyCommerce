using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IStormyRepository<StormyOrder> _orderRepository;
        private readonly IStormyRepository<OrderHistory> _orderHistoryRepository;        
        public OrderService(IStormyRepository<StormyOrder> orderRepository
            ,IStormyRepository<OrderHistory> orderHistoryRepository)
        {
            _orderRepository = orderRepository;
            _orderHistoryRepository = orderHistoryRepository;
        }
        public async Task<Result<OrderDto>> CancelOrderAsync(long id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
                return new Result<OrderDto>(null,false,"order don't exist");                     

            order.Status = OrderStatus.Canceled;
            order.LastModified = DateTimeOffset.UtcNow;
            order.Items.ToList().ForEach(item =>
            {
                item.Product.UnitsInStock += item.Quantity;
                item.Product.UnitsOnOrder -= item.Quantity;
            });
            //#warning Pay attention! Be double careful when editing orders.
            await _orderRepository.UpdateAsync(order);
            return new Result<OrderDto>(order.ToOrderDto(),true,"no error");
        }
        //TODO:#warning Remember to edit the StormyProducts(items) on the Controller to sync the UnitsInStock
        public async Task<Result<OrderDto>> CreateOrderAsync(StormyOrder entry)
        {
            if (entry == null)
                return new Result<OrderDto>(entry.ToOrderDto(), false , "We need valid info to create a order,order data don't have any data");
            if (entry.Items == null)
                return new Result<OrderDto>(entry.ToOrderDto(), false , "You have no items to create a order");
            
            await _orderRepository.AddAsync(entry);
            var result = (await _orderRepository.GetByIdAsync(entry.Id)).ToOrderDto();
            return Result.Ok<OrderDto>(result);
        }
        //! If you don't do this right, a order could for example,have your price changed easily        
        public async Task<Result> EditOrderAsync(long id, StormyOrder entity)
        {
            var _entity = await _orderRepository.GetByIdAsync(id);
            if (_entity.Id != entity.Id)
                return Result.Fail("you can't edit the Id of the order");
            if (_entity.Customer != entity.Customer)
                return Result.Fail("you can't edit a order of other customer");
            //if(_entity.PaymentDate ==)
            await _orderRepository.UpdateAsync(entity);
            return Result.Ok();
        }
        public async Task<Result<OrderDto>> GetOrderByIdAsync(long id)
        {
            var entity = await _orderRepository.GetByIdAsync(id);

            if (entity == null)
                return new Result<OrderDto>(null, false, "order don't exists");

            var result = entity.ToOrderDto();
            return new Result<OrderDto>(result,true,"no error");
        }
        public Task<OrderHistoryDto> GetOrderHistoryAsync()
        {
            throw new System.NotImplementedException();
        }
        public async Task<Result<IList<StormyOrder>>> GetOrdersAsync()
        {
            return new Result<IList<StormyOrder>>(await _orderRepository.GetAllAsync(),true,"no error");
        }
        //public Task<IList<OrderDto>> GetCustomerOrdersAsync()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
