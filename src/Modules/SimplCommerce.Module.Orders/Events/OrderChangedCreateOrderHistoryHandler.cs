using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Newtonsoft.Json;
using SimplCommerce.Module.Orders.Models;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Orders.Events
{
    public class OrderChangedCreateOrderHistoryHandler : INotificationHandler<OrderChanged>
    {
        private readonly IStormyRepository<OrderHistory> _orderHistoryRepository;

        public OrderChangedCreateOrderHistoryHandler(IStormyRepository<OrderHistory> orderHistoryRepository)
        {
            _orderHistoryRepository = orderHistoryRepository;
        }

        public async Task Handle(OrderChanged notification, CancellationToken cancellationToken)
        {
            var orderHistory = new OrderHistory
            {
                OrderId = notification.OrderId,
                CreatedOn = DateTimeOffset.Now,
                CreatedById = notification.UserId,
                OldStatus = notification.OldStatus,
                NewStatus = notification.NewStatus,
                Note = notification.Note,
            };

            if(notification.Order != null)
            {
                orderHistory.OrderSnapshot = JsonConvert.SerializeObject(notification.Order);
            }

            _orderHistoryRepository.Add(orderHistory);
            await _orderHistoryRepository.SaveChangesAsync();
        }
    }
}
