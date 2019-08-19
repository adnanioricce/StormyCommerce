using StormyCommerce.Infraestructure.Data;
using SimplCommerce.Module.SampleData.Extensions;
namespace SimplCommerce.Module.SampleData.Extensions
{
    public static class DatabaseSeedExtensions
    {
        public static void SeedDbContext(this StormyDbContext dbContext)
        {
            //dbContext.AddRange(Seeders.StormyProductSeed(50));
            //dbContext.AddRange(Seeders.AddressSeed(2));
            //dbContext.AddRange(Seeders.BrandSeed(20));
            //dbContext.AddRange(Seeders.CategorySeed(15));
            //dbContext.AddRange(Seeders.MediaSeed(100));
            //dbContext.AddRange(Seeders.ProductAttributeGroupSeed(5));
            //dbContext.AddRange(Seeders.ProductAttributeSeed(20));
            //dbContext.AddRange(Seeders.ApplicationUserSeed(5));
            //dbContext.AddRange(Seeders.StormyCustomerSeed(5));
            //dbContext.AddRange(Seeders.StormyVendorSeed(20));
            //dbContext.AddRange(Seeders.ProductLinkSeed(50));            
            dbContext.SaveChanges();
        }        
    }
}
