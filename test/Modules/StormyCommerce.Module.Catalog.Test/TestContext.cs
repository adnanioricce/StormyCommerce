using Microsoft.EntityFrameworkCore;
using StormyCommerce.Infraestructure.Data;

namespace StormyCommerce.Module.Catalog.Test
{
    public static class TestContext
    {
        public static StormyCommerce.Infraestructure.Data.StormyDbContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<StormyDbContext>();
            builder.UseInMemoryDatabase();
            var dbContext = new StormyDbContext(builder.Options);
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
    }
}
