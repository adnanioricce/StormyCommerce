using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Infraestructure.Data;

namespace TestHelperLibrary.Utils
{
    public class StormyDbContextInitializer
    {
        // private readonly Dictionary<int, StormyProduct> Products = new Dictionary<int, StormyProduct>();
        public static void Initialize(StormyDbContext context)
        {
            var initializer = new StormyDbContextInitializer();
            initializer.SeedTestDb(context);
        }

        public void SeedTestDb(StormyDbContext context)
        {
            context.Database.EnsureCreated();
            context.AddRange(Seeders.EntitySeed(5, "Product"));
            context.AddRange(Seeders.EntitySeed(5, "Category"));
            context.AddRange(Seeders.EntitySeed(5, "Brand"));
        }
    }
}
