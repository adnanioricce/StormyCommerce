using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class ProductAttributeMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductAttribute>();
            modelBuilder.Entity<ProductAttributeGroup>(mapper =>
            {
                mapper.Property(prop => prop.Name).HasMaxLength(450).IsRequired();
            });
        }
    }
}
