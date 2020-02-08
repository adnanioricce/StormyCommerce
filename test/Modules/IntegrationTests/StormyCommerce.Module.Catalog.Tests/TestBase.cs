using System;
using System.Linq;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Data;
using GenFu;
using SimplCommerce.Module.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace StormyCommerce.Module.Catalog.Tests
{
    public class TestBase : IDisposable
    {
        private readonly SimplDbContext _dbContext;
        public TestBase()
        {            
            var builder = new DbContextOptionsBuilder<SimplDbContext>();
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlite()
                .AddDbContext<SimplDbContext>()
                .BuildServiceProvider();
            builder.UseSqlite("DataSource=testDb.db")
                .EnableSensitiveDataLogging()
                .UseInternalServiceProvider(serviceProvider);            
            _dbContext = new SimplDbContext(builder.Options);
            var products = A.ListOf<Product>(24);
            var vendors = A.ListOf<Vendor>(2);
            _dbContext.AddRange(vendors);
            _dbContext.SaveChanges();
            // products.            
            // for(int i = 0;i < (products.Count/2);++i){
            //     products[i].VendorId = vendors.FirstOrDefault().Id;                
            // }
            // for(int j = products.Count/2;j < (products.Count/2);++j){
            //     products[j].VendorId = vendors.Last().Id;
            // }
            _dbContext.AddRange(products);
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            // _dbContext.
        }
    }
}