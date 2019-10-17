using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.SampleData
{
    public static class DatabaseSeedExtensions
    {
        public static void SeedDbContext(this StormyDbContext dbContext)
        {
            var destinationAddresses = Seeders.AddressSeed(10);
            var billingAddresses = Seeders.AddressSeed(10);
            billingAddresses.ForEach(a => a.Id = a.Id + 10);
            var reviews = Seeders.ReviewSeed(10);
            var stormyCustomers = Seeders.StormyCustomerSeed(10);
            for (int i = 0; i < reviews.Count; ++i)
            {
                stormyCustomers[i].CustomerReviewsId = i;                    
                reviews[i].StormyCustomerId = i;
                stormyCustomers[i].DefaultBillingAddressId = i;
            }
            for (int j = 0; j < billingAddresses.Count; ++j)
            {
                stormyCustomers[j].DefaultShippingAddressId = j;
            }
            dbContext.AddRange(destinationAddresses);
            dbContext.AddRange(billingAddresses);
            dbContext.SaveChanges();
            dbContext.AddRange(reviews);
            dbContext.AddRange(stormyCustomers);
            dbContext.SaveChanges();
            dbContext.AddRange(Seeders.StormyVendorSeed(10));
            dbContext.SaveChanges();
            dbContext.AddRange(Seeders.CategorySeed(10));
            dbContext.SaveChanges();
            dbContext.AddRange(Seeders.BrandSeed(10));
            dbContext.SaveChanges();
            dbContext.AddRange(Seeders.MediaSeed(50));
            dbContext.SaveChanges();
            dbContext.AddRange(Seeders.StormyProductSeed(50));
            dbContext.SaveChanges();
            dbContext.AddRange(Seeders.ProductLinkSeed(50));
            dbContext.SaveChanges();
            
            dbContext.AddRange(Seeders.ProductAttributeGroupSeed(5));
            dbContext.SaveChanges();
            dbContext.AddRange(Seeders.ProductAttributeSeed(20));
            dbContext.SaveChanges();
            
        }
    }
}
