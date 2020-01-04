using System;
using Microsoft.EntityFrameworkCore;


namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class ProductAttributeMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductAttribute>();
            //modelBuilder.Entity<ProductAttributeGroup>(mapper =>
            //{
            //    mapper.Property(prop => prop.Name).HasMaxLength(450).IsRequired();
            //});
        }
    }
}
