using StormyCommerce.Core.Events.Entity;
using MediatR;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Services
{
	public class EntityService : IEntityService
	{
		private readonly IStormyRepository<Entity> entityRepository;
		private readonly IMediator mediator;
		public EntityService(IStormyRepository<Entity> _entityRepository,IMediator _mediator)
		{
            entityRepository = _entityRepository;
			mediator = _mediator;
		}
		//Wtf this do?
		public string ToSafeSlug(string slug, long entityId, string entityTypeId)
        {
            var i = 2;
			while (true)
            {
                var entity = entityRepository.Table.FirstOrDefault(x => x.Slug == slug);
		        if (entity != null && !(entity.EntityId == entityId && entity.EntityTypeId == entityTypeId))
                {
		            slug = string.Format("{0}-{1}", slug, i);
                	i++;
		        }
                else
		        {
                	break;
		        }
            }
	        return slug;
        }

        public Entity Get(long entityId, string entityTypeId)
        {
            return entityRepository.Table.FirstOrDefault(x => x.EntityId == entityId && x.EntityTypeId == entityTypeId);
        }

	    public void Add(string name, string slug, long entityId, string entityTypeId)
        {
	        var entity = new Entity
        	{
                Name = name,
	            Slug = slug,
        	    EntityId = entityId,
                EntityTypeId = entityTypeId
	        };

        	entityRepository.AddAsync(entity);
	    }

        public void Update(string newName, string newSlug, long entityId, string entityTypeId)
	    {
        	var entity = entityRepository.Table.First(x => x.EntityId == entityId && x.EntityTypeId == entityTypeId);
	        entity.Name = newName;
        	entity.Slug = newSlug;
	    }

        public void Delete(long entityId, string entityTypeId)
	    {
        	var entity = entityRepository.Table.FirstOrDefault(x => x.EntityId == entityId && x.EntityTypeId == entityTypeId);

	        if (entity != null)
        	{
                mediator.Publish(new EntityDeleting { EntityId = entity.Id });
	            entityRepository.Delete(entity);
        	}
	    }
	}
}
