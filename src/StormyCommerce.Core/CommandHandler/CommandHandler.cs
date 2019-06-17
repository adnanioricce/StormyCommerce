using MediatR;
using StormyCommerce.Core.Bus;
using StormyCommerce.Core.Commands;
using StormyCommerce.Core.Notifications;
using StormyCommerce.Core.Uow;
using System.Linq;
namespace StormyCommerce.Core.CommandHandler
{
    public class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IMediatorHandler _bus;
        private readonly DomainNotificationHandler _notifications;
        public CommandHandler(IUnitOfWork uow,IMediatorHandler bus,INotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _notifications = (DomainNotificationHandler)notifications;
            _bus = bus;
        }
        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }
        public bool Commit()
        {
            if (_notifications.HasNotifications())
                return false;
            if (_uow.Commit(true))
                return true;

            _bus.RaiseEvent(new DomainNotification("Commit", "a problem was throwed when saving the data"));
            return false;
        }
    }
}
