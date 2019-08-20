using StormyCommerce.Infraestructure.Data;
using SimplCommerce.Module.SampleData.Extensions;
namespace SimplCommerce.Module.SampleData.Extensions
{
    public static class DatabaseSeedExtensions
    {
        public static void SeedDbContext(this StormyDbContext dbContext)
        {
            dbContext.AddRange(Seeders.StormyVendorSeed(10));
            dbContext.AddRange(Seeders.CategorySeed(10));
            dbContext.AddRange(Seeders.BrandSeed(10));
            dbContext.AddRange(Seeders.MediaSeed(50));
            dbContext.AddRange(Seeders.StormyProductSeed(50));
            dbContext.AddRange(Seeders.ProductLinkSeed(50));
            dbContext.AddRange(Seeders.AddressSeed(10));
            dbContext.AddRange(Seeders.ProductAttributeGroupSeed(5));
            dbContext.AddRange(Seeders.ProductAttributeSeed(20));
            dbContext.AddRange(Seeders.ApplicationUserSeed(5));
            dbContext.AddRange(Seeders.StormyCustomerSeed(5));
            dbContext.SaveChanges();
        }        
    }
}
