using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Media;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class MediaMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>(entity => {
                entity.ToTable("Core_Media");

                entity.Property(e => e.Caption)
                    .HasMaxLength(450);

                entity.Property(e => e.FileName)
                    .HasMaxLength(450);
                entity.HasKey(prop => prop.Id);

                entity.Property(prop => prop.Id)
                    .ValueGeneratedOnAdd();
            });
        }
    }
}
