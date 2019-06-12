using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Infraestructure.Data;
using System;
<<<<<<< HEAD

namespace StormyCommerce.Core.Test
=======
namespace StormyCommerce.Module.Catalog.Test
>>>>>>> 8b17fc71e1dba81609e1b396ebfc7ef510bc1d04
{
    public class TestContext
    {
<<<<<<< HEAD
        public StormyCommerce.Infraestructure.Data.StormyDbContext GetDbContext(DbContextOptions<StormyDbContext> dbContextOptions)
        {            
            var dbContext = new StormyDbContext(dbContextOptions);
=======
        public static StormyCommerce.Infraestructure.Data.StormyDbContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<StormyDbContext>();
            builder.UseInMemoryDatabase($"{Guid.NewGuid().ToString("N")}-FakeStormyDatabase");
            builder.EnableSensitiveDataLogging();
            var dbContext = new StormyDbContext(builder.Options);
>>>>>>> 8b17fc71e1dba81609e1b396ebfc7ef510bc1d04
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
        public static DbContextOptions<StormyDbContext> GetDbOptions()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<StormyDbContext>();
            builder.UseInMemoryDatabase($"{Guid.NewGuid().ToString("N")}")
                .UseInternalServiceProvider(serviceProvider);
            return builder.Options;
        }
    }
}
