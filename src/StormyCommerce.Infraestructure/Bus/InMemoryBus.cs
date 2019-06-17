using System.Threading.Tasks;
using MediatR;
using StormyCommerce.Core.Bus;
using StormyCommerce.Core.Commands;
using StormyCommerce.Core.Events;

namespace StormyCommerce.Infraestructure.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventStore _eventStore;
        public InMemoryBus(IEventStore eventStore,IMediator mediator)
        {
            _eventStore = eventStore;
            _mediator = mediator;
        }
        public Task RaiseEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
                _eventStore?.Save(@event);

            return _mediator.Publish(@event);
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
