using MediatR;

namespace StormyCommerce.Core.Events
{
    public class EntityDeleting : INotification
    {
        public long EntityId { get; set; }
    }
}
