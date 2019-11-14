using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.SampleData
{
    public static class DatabaseSeedExtensions
    {
        public static void SeedDbContext(this StormyDbContext dbContext)
        {
            var customers = Seeders.StormyCustomerSeed(10, true);
            dbContext.AddRange(customers);
            dbContext.SaveChanges();           
            var products = Seeders.StormyProductSeed(50);             
            dbContext.AddRange(products);
            dbContext.SaveChanges();            
            
        }
    }
}
