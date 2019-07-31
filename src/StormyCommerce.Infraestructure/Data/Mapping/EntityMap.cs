using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping
{
    public class EntityMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityType>(entity =>
            {
                //entity.HasKey(prop => prop.Id);
                entity.Property(prop => prop.Id).HasMaxLength(450);                
                entity.Property(prop => prop.AreaName).HasMaxLength(450);
                entity.Property(prop => prop.RoutingController).HasMaxLength(450);
                entity.Property(prop => prop.RoutingAction).HasMaxLength(450);                
                
            });
            modelBuilder.Entity<Entity>(entity =>
            {                
                entity.HasKey(x => x.Id);
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.Property(x => x.EntityId);
                entity.Property(prop => prop.Slug).HasMaxLength(450).IsRequired();
                entity.Property(prop => prop.Name).HasMaxLength(450).IsRequired();
                entity.Property(prop => prop.EntityTypeId).HasMaxLength(450).IsRequired();
                entity.HasQueryFilter(prop => prop.IsDeleted);                
            });
        }
    }
}
