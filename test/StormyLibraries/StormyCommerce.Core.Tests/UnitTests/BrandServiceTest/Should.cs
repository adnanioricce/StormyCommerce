using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Tests.Helpers;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.BrandServiceTest
{
    public class Should
    {
        [Fact]
        public async Task AddBrandEntityAsync()
        {
            //Given
            using(var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {                
                var service = new Core.Services.BrandService(new StormyRepository<Brand>(dbContext),null);
                //When
                await service.AddAsync(SampleBrandDataHelper.GetSampleData());
                var entity = dbContext.Query<Brand>().FirstOrDefault();
                //Then
                Assert.Equal(1,entity.Id);
            }            
        }    
        [Fact]
        public async Task DeleteBrandEntityAsync()
        {
            using(var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                //Given
                dbContext.Add(SampleBrandDataHelper.GetSampleData());
                dbContext.SaveChanges();
                var service = new Core.Services.BrandService(new StormyRepository<Brand>(dbContext),null);
                Assert.Equal(1,dbContext.Query<Brand>().Count());
                //When
                await service.DeleteAsync(1);
                //Then
                Assert.Equal(0,dbContext.Query<Brand>().Count());
            }                                
        }
        [Fact]
        public void UpdateBrandEntityAsync()
        {
            //Given
        
            //When
        
            //Then
        }
    }
}