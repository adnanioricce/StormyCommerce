using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

using SimplCommerce.Module.Orders.Models;

namespace StormyCommerce.Module.Orders.Interfaces
{
    public interface IOrderService
    {        
        Task<Result<OrderDto>> CreateOrderAsync(Order entry);
        Task<Result> EditOrderAsync(long id, Order entity);
        Task<Result> EditOrderAsync(Guid uniqueId, Order entity);
        Task<Result<OrderDto>> CancelOrderAsync(long id);
        Task<Result<OrderDto>> GetOrderByIdAsync(long id);
        Task<Result<IList<Order>>> GetOrdersAsync();
        Task<Result<OrderDto>> GetOrderByUniqueIdAsync(Guid uniqueId);
        Task<Order> GetOrderByUniqueIdAsync(Guid uniqueId);
        Task<List<OrderDto>> GetAllOrdersFromCustomer(long customerId);
    }
}
