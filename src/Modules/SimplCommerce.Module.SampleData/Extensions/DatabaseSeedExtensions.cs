using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.SampleData
{
    public static class DatabaseSeedExtensions
    {
        public static void SeedDbContext(this StormyDbContext dbContext)
        {                        
            dbContext.AddRange(Seeders.StormyCustomerSeed(10,true));
            dbContext.SaveChanges();           
            var products = Seeders.StormyProductSeed(50,true); 
            // foreach (var item in products)
            // {
            //     dbContext.AddRange(item.Medias);
            //     dbContext.SaveChanges();
            //     dbContext.Add(item.Brand);
            //     dbContext.SaveChanges();
            //     dbContext.Add(item.Category);
            //     dbContext.SaveChanges();
            //     dbContext.Add(item.Vendor);
            //     dbContext.SaveChanges();
            // }
            dbContext.AddRange(products);
            dbContext.SaveChanges();            
            
        }
    }
}
