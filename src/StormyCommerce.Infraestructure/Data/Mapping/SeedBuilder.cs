using Microsoft.EntityFrameworkCore;

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
