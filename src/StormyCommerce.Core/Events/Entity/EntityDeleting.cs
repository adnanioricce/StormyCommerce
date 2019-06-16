using MediatR;

namespace StormyCommerce.Core.Events.Entity
{
    public class EntityDeleting : INotification
    {
        public long EntityId { get; set; }
    }
}
