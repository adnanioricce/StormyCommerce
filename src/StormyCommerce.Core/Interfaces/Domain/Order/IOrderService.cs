using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Order
{
    public interface IOrderService
    {
        Task<Result> CreateOrder(object entry);
        Task<Result> EditOrder(int id,object entity);
        Task<Result> CancelOrder(int id);        
        Task<OrderDto> GetOrderById(int id);
        Task<IList<OrderDto>> GetOrders();
        Task<OrderHistoryDto> GetOrderHistory();
    }
}
