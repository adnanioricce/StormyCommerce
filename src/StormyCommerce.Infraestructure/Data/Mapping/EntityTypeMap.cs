using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping
{
    public class EntityTypeMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.ToTable("Core_EntityType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaName).HasMaxLength(450);

                entity.Property(e => e.RoutingAction).HasMaxLength(450);

                entity.Property(e => e.RoutingController).HasMaxLength(450);
                entity.HasQueryFilter(prop => !prop.IsDeleted);
            });
        }
    }
}
