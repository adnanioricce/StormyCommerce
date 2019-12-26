using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Cms;

namespace StormyCommerce.Infraestructure.Data.Mapping.Cms
{
    public class WidgetZoneMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WidgetZone>(entity =>
            {
                entity.ToTable("Core_WidgetZone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);
            });
        }
    }
}
