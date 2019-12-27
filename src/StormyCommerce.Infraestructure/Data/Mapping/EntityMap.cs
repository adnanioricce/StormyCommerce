using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping
{
    public class EntityMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Entity>(entity =>
            {
                entity.ToTable("Core_Entity");

                entity.HasKey(x => x.Id);

                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();

                entity.HasIndex(e => e.EntityTypeId);
                
                entity.Property(prop => prop.Slug)
                    .HasMaxLength(450)
                    .IsRequired();

                entity.Property(prop => prop.Name)
                    .HasMaxLength(450)
                    .IsRequired();

                entity.Property(prop => prop.EntityTypeId)
                    .HasMaxLength(450)
                    .IsRequired();

                entity.HasOne(prop => prop.EntityType)
                    .WithMany()
                    .HasForeignKey(d => d.EntityTypeId);

                entity.HasQueryFilter(prop => !prop.IsDeleted);
            });
        }
    }
}
