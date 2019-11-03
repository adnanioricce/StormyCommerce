using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
namespace StormyCommerce.Core.Interfaces.Domain.Order
{
    public interface IOrderService
    {
        Task<Result<OrderDto>> CreateOrderAsync(StormyOrder entry);
        Task<Result> EditOrderAsync(long id, StormyOrder entity);
        Task<Result<OrderDto>> CancelOrderAsync(long id);
        Task<Result<OrderDto>> GetOrderByIdAsync(long id);
        Task<Result<IList<StormyOrder>>> GetOrdersAsync();
        Task<Result<OrderDto>> GetOrderByUniqueIdAsync(Guid uniqueId);
    }
}
