<<<<<<< HEAD
using System;
=======
>>>>>>> fa2b276b6842723920e5f61eeffff6e51039b4b6
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
<<<<<<< HEAD
=======
using StormyCommerce.Core.Entities.Common;
>>>>>>> fa2b276b6842723920e5f61eeffff6e51039b4b6
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;

namespace StormyCommerce.Infraestructure.Data.Mapping
{
    public class SeedBuilder : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Entity>().HasData(Seeders.EntitySeed(20,"Product"));
            // modelBuilder.Entity<Address>().HasData(Seeders.AddressSeed(10));
            // modelBuilder.Entity<Brand>().HasData(Seeders.BrandSeed(10)); 
            // modelBuilder.Entity<Category>().HasData(Seeders.CategorySeed(10));    
            // modelBuilder.Entity<Media>().HasData(Seeders.MediaSeed(20));
            // modelBuilder.Entity<StormyProduct>().HasData(Seeders.StormyProductSeed(20));            
            // modelBuilder.Entity<StormyVendor>().HasData(Seeders.StormyVendorSeed(10));       
        }
    }
}
