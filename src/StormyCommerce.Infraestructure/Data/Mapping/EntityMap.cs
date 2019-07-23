using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping
{
    public class EntityMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Entity>(e =>
            {                
                e.HasKey(x => x.Id);
                e.Property(x => x.EntityId);
                e.HasQueryFilter(entity => entity.IsDeleted);
            });
        }
    }
}
