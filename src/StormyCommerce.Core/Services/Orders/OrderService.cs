using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IStormyRepository<StormyOrder> _orderRepository;        
        public OrderService(IStormyRepository<StormyOrder> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Task<Result> CancelOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> CreateOrder(object entry)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> EditOrder(int id, object entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderDto> GetOrderById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderHistoryDto> GetOrderHistory()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<OrderDto>> GetOrders()
        {
            throw new System.NotImplementedException();
        }
    }
}
