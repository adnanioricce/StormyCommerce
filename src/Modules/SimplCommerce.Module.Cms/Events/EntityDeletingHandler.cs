using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Cms.Models;
using StormyCommerce.Core.Events;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Cms.Events
{
    public class EntityDeletingHandler : INotificationHandler<EntityDeleting>
    {
        private readonly IStormyRepository<MenuItem> _menuItemRepository;

        public EntityDeletingHandler(IStormyRepository<MenuItem> menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public Task Handle(EntityDeleting notification, CancellationToken cancellationToken)
        {
            var items = _menuItemRepository.Query().Where(x => x.EntityId == notification.EntityId).ToList();
            foreach(var item in items)
            {
                _menuItemRepository.Delete(item);
            }

            return Task.CompletedTask;
        }
    }
}
