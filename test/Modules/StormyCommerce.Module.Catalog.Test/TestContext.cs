using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Infraestructure.Data;
using System;

namespace StormyCommerce.Module.Catalog.Test
{
    public class TestContext
    {
        public StormyCommerce.Infraestructure.Data.StormyDbContext GetDbContext()
        {                             
            var builder = new DbContextOptionsBuilder<StormyDbContext>();
            builder.UseInMemoryDatabase($"{Guid.NewGuid().ToString("N")}-FakeStormyDatabase");
            builder.EnableSensitiveDataLogging();
            var dbContext = new StormyDbContext(builder.Options);
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
