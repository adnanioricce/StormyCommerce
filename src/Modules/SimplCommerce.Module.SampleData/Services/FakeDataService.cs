using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.SampleData.Services
{
    public class FakeDataService
    {
        private readonly StormyDbContext dbContext;
        public FakeDataService(StormyDbContext stormyDbContext)
        {
            dbContext = stormyDbContext;
        }

        public void SeedDatabase()
        {
            dbContext.AddRange(Seeders.BrandSeed(10,true));
            dbContext.AddRange(Seeders.EntitySeed(10,"product",true));
            dbContext.AddRange(Seeders.MediaSeed(10,true));
            dbContext.AddRange(Seeders.AddressSeed(10,true));
            dbContext.AddRange(Seeders.ReviewSeed(20,true));
            dbContext.AddRange(Seeders.ProductAttributeSeed(10,true));
            dbContext.AddRange(Seeders.StormyCustomerSeed(2));
            dbContext.AddRange(Seeders.StormyOrderSeed(4));
            dbContext.AddRange(Seeders.StormyProductSeed(10,true));
            dbContext.AddRange(Seeders.StormyVendorSeed(10,true));
            dbContext.SaveChanges();
        }
    }
}
