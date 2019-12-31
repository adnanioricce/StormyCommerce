using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.SampleData
{
    public static class DatabaseSeedExtensions
    {
        public static void SeedDbContext(this StormyDbContext dbContext)
        {
            //var customers = Seeders.StormyCustomerSeed(10, true);
            //dbContext.AddRange(customers);
            //dbContext.SaveChanges();                       
            //dbContext.AddRange(Seeders.StormyProductSeed(50));
            //dbContext.SaveChanges();
            //dbContext.AddRange(Seeders.OrderSeed(2));
            //dbContext.SaveChanges();
            //dbContext.AddRange(Seeders.ShipmentSeed(4));
            //dbContext.SaveChanges();
        }
    }
}
