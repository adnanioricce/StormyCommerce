using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Services.Catalog
{
    public class EntityService : IEntityService
    {
        private readonly IStormyRepository<Entity> entityRepository;

        public EntityService(IStormyRepository<Entity> _entityRepository)
        {
            entityRepository = _entityRepository;
        }

        //Wtf this do?
        public string ToSafeSlug(string slug, long entityId, string entityTypeId)
        {
            var i = 2;
            while (true)
            {
                var entity = entityRepository.Query().FirstOrDefault(x => x.Slug == slug);
                if (entity != null && !(entity.Id == entityId && entity.EntityTypeId == entityTypeId))
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
            return entityRepository.Query().FirstOrDefault(x => x.Id == entityId && x.EntityTypeId == entityTypeId);
        }

        public void Add(string name, string slug, long entityId, string entityTypeId)
        {
            var entity = new Entity
            {
                Name = name,
                Slug = slug,
                Id = entityId,
                EntityTypeId = entityTypeId
            };

            entityRepository.AddAsync(entity);
        }

        public void Update(string newName, string newSlug, long entityId, string entityTypeId)
        {
            var entity = entityRepository.Query().First(x => x.Id == entityId && x.EntityTypeId == entityTypeId);
            entity.Name = newName;
            entity.Slug = newSlug;
        }

        public async Task DeleteAsync(long entityId, string entityTypeId)
        {
            var entity = entityRepository.Query().Where(x => x.Id == entityId && x.EntityTypeId == entityTypeId).FirstOrDefault();
            if (entity != null)
            {
                //mediator.Publish(new EntityDeleting { EntityId = entity.Id });
                entity.IsDeleted = true;
                await entityRepository.SaveChangesAsync();
            }
        }
    }
}
