using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class ProductOptionMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductOption>(mapper =>
            //{
            //    mapper.Property(p => p.Name).HasMaxLength(450).IsRequired();
            //});
            //modelBuilder.Entity<ProductOptionValue>(mapper =>
            //{
            //    mapper.Property(p => p.Value).HasMaxLength(450);
            //    mapper.Property(p => p.DisplayType).HasMaxLength(450);
            //});
            //modelBuilder.Entity<ProductOptionCombination>(mapper =>
            //{
            //    mapper.Property(p => p.Value).HasMaxLength(450);
            //});
        }
    }
}
