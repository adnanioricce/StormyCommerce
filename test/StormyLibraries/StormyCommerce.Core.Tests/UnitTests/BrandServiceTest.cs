using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Tests.Helpers;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests
{
    public class BrandServiceTest
    {
        public Mock<IEntityService> fakeEntityService { get; }
        public BrandServiceTest()
        {
            fakeEntityService = new Mock<IEntityService>();
            fakeEntityService.Setup(x => x.ToSafeSlug(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>())).Returns("fake-slug");            

        }
        [Fact]
        public async Task AddBrandEntityAsync_WithValidEntry_ShouldCreateEntryOnDatabase()
        {
            //Given
            using(var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {                
                var service = new BrandService(new StormyRepository<Brand>(dbContext),fakeEntityService.Object);
                //When
                await service.AddAsync(SampleBrandDataHelper.GetSampleData());
                var entity = await service.GetBrandByIdAsync(1);
                //Then
                Assert.Equal(1,entity.Id);
            }            
        }    
        [Fact]
        public async Task DeleteBrandEntityAsync_ForExistingEntityAndValidInput_ShouldDeleteEntityFromDatabase()
        {
            using(var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                //Given
                dbContext.Add(SampleBrandDataHelper.GetSampleData());
                dbContext.SaveChanges();
                var service = new BrandService(new StormyRepository<Brand>(dbContext),null);
                var brands = await service.GetAllBrandsAsync();
                Assert.Equal(1,brands.Count);
                //When
                await service.DeleteAsync(1);
                brands = await service.GetAllBrandsAsync();
                //Then
                Assert.Equal(0,brands.Count);
            }                                
        }
        [Fact]
        public async Task UpdateBrandEntityAsync_ToReplaceExistingEntityWithValidEntry_ShouldReplaceEntityWithProvided()
        {            
            using (var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                //Given
                dbContext.Add(SampleBrandDataHelper.GetSampleData());
                dbContext.SaveChanges();
                var service = new BrandService(new StormyRepository<Brand>(dbContext), fakeEntityService.Object);
                var oldBrand = await service.GetBrandByIdAsync(1);
                var newBrand = SampleBrandDataHelper.GetSingleBrandData();
                //When
                await service.UpdateAsync(newBrand);
                var brand = service.GetBrandByIdAsync(1);
                //Then
                Assert.NotSame(newBrand,oldBrand);
            }
        }
    }
}
