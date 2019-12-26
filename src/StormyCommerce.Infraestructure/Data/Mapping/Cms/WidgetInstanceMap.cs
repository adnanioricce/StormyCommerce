using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Cms;

namespace StormyCommerce.Infraestructure.Data.Mapping.Cms
{
    public class WidgetInstanceMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WidgetInstance>(entity =>
            {
                entity.ToTable("Core_WidgetInstance");

                entity.HasIndex(e => e.WidgetId);

                entity.HasIndex(e => e.WidgetZoneId);

                entity.Property(e => e.CreatedOn).HasColumnType("timestamp with time zone");

                entity.Property(e => e.LastModified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.Property(e => e.PublishEnd).HasColumnType("timestamp with time zone");

                entity.Property(e => e.PublishStart).HasColumnType("timestamp with time zone");

                entity.Property(e => e.WidgetId).HasMaxLength(450);
                
            });
        }
    }
}
