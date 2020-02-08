using System;
using System.Linq;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Catalog.Models;
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
            var products = ProductSeeder.InsertProductSeed(10).ToArray();            
            var vendor = new Vendor{
                Name = "test vendor",
                Slug = "test-vendor"                
            };            
            var category = CategorySeeder.InsertCategorySeed();
            _dbContext.Add(vendor);
            _dbContext.Add(category);
            _dbContext.SaveChanges();            
            for(int i = 0;i < products.Count();++i){
                products[i].VendorId = vendor.Id;                
                products[i].AddCategory(new ProductCategory{
                    ProductId = products[i].Id,
                    CategoryId = category.Id
                });
            }            
            _dbContext.AddRange(products);
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {                        
            _dbContext.Dispose();
        }
    }
}