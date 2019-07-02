using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Tests.Helpers;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Module.Catalog.Test.Helpers;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.CategoryServiceTest
{
    public class Should
    {        
        [Fact]
        public async Task GetCategoryByIdAsync()
        {
            using (var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                dbContext.AddRange(SampleCategoryDataHelper.GetSampleCategoryData());
                dbContext.SaveChanges();
                
                var service = new Core.Services.CategoryService(new StormyRepository<Category>(dbContext),null);
                //Act
                var entity = await service.GetCategoryByIdAsync(1);
                //Assert
                Assert.Equal(1, entity.Id);
            }
        }
        [Fact]
        public async Task GetAllCategories()
        {
            using (var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                dbContext.AddRange(SampleCategoryDataHelper.GetSampleCategoryData());
                dbContext.SaveChanges();
                
                var service = new Core.Services.CategoryService(new StormyRepository<Category>(dbContext), null);
                //Act
                var entities = await service.GetAllCategoriesAsync();
                //Assert
                Assert.Equal(1,entities.Count);
            }
        }        
        
        //[Fact]
        //public async Task Get
    }
}
