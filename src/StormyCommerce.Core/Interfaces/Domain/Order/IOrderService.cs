using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Order
{
    public interface IOrderService
    {
        Task CreateOrder(object entry);
        Task EditOrder(int id,object entity);
        Task CancelOrder(int id);        
        Task<object> GetOrderById(int id);
        Task<IList<object>> GetOrders();
        Task<object> GetOrderHistory();
    }
}