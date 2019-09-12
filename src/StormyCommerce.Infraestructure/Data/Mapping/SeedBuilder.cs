using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;

namespace StormyCommerce.Infraestructure.Data.Mapping
{
    public class SeedBuilder : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<StormyVendor>(e => {
                e.HasData(Seeders.StormyVendorSeed(10));
            });
            modelBuilder.Entity<Media>(e => {
                e.HasData(Seeders.MediaSeed(50));
            });            
            modelBuilder.Entity<Entity>(e => {
                e.HasData(Seeders.EntitySeed(10));
            });
            modelBuilder.Entity<Brand>(e => {
                e.HasData(Seeders.BrandSeed(10));
            });
            modelBuilder.Entity<Category>(e => {
                e.HasData(Seeders.CategorySeed(10));
            });            
            modelBuilder.Entity<StormyProduct>(e => {
                e.HasData(Seeders.StormyProductSeed(50));
            });
        }
    }
}
