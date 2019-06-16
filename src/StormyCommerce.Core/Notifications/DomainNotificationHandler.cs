
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace StormyCommerce.Core.Notifications
{
    public class DomainNotificationHandler : INotificationHandler<DomainNotification>
    {
        private IList<DomainNotification> notifications;
        public DomainNotificationHandler()
        {
            notifications = new List<DomainNotification>();
        }
        public Task Handle(DomainNotification notification, CancellationToken cancellationToken)
        {
            notifications.Add(notification);

            return Task.CompletedTask;
        }
        public virtual IList<DomainNotification> GetNotifications()
        {
            return notifications;
        }
        public virtual bool HasNotifications()
        {
            return GetNotifications().Any();               
        }
        public void Dispose()
        {
            notifications = new List<DomainNotification>();
        }
    }
}
