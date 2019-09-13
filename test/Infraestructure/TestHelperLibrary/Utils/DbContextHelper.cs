using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Infraestructure.Data;
using System;

namespace TestHelperLibrary.Utils
{
    public static class DbContextHelper
    {
        public static StormyDbContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<StormyDbContext>();
            builder.UseInMemoryDatabase($"{Guid.NewGuid().ToString("N")}-FakeStormyDatabase");
            builder.EnableSensitiveDataLogging();
            var dbContext = new StormyDbContext(GetDbOptions());
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            return dbContext;
        }

        public static StormyDbContext GetDbContext(DbContextOptions<StormyDbContext> dbContextOptions)
        {
            var dbContext = new StormyDbContext(dbContextOptions);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            return dbContext;
        }

        public static DbContextOptions<StormyDbContext> GetDbOptions()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<StormyDbContext>()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<StormyDbContext>();
            builder.UseInMemoryDatabase($"{Guid.NewGuid().ToString("N")}")
                .EnableSensitiveDataLogging()
                .UseInternalServiceProvider(serviceProvider);
            return builder.Options;
        }
    }
}
