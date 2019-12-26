using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Cms;

namespace StormyCommerce.Infraestructure.Data.Mapping.Cms
{
    public class WidgetMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Widget>(entity =>
            {
                entity.ToTable("Core_Widget");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateUrl).HasMaxLength(450);

                entity.Property(e => e.CreatedOn).HasColumnType("timestamp with time zone");

                entity.Property(e => e.EditUrl).HasMaxLength(450);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ViewComponentName).HasMaxLength(450);
            });
        }
    }
}
