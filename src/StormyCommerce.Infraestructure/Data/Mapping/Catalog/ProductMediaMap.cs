using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Media;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class ProductMediaMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductMedia>(entity =>
            //{
            //    entity.HasKey(prop => prop.Id);
            //    entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
            //    entity.HasOne(prop => prop.Media)
            //        .WithMany()
            //        .HasForeignKey(prop => prop.MediaId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .IsRequired();
            //    entity.HasOne(prop => prop.Product)
            //        .WithMany()
            //        .HasForeignKey(p => p.StormyProductId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .IsRequired();
            //});
        }
    }
}
