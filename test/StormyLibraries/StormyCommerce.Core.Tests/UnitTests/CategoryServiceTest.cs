using Moq;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Tests.Helpers;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Module.Catalog.Test.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests
{
    public class CategoryServiceTest
    {
        public Mock<IEntityService> FakeEntityService { get; set; }
        public CategoryServiceTest()
        {
            FakeEntityService = new Mock<IEntityService>();
            FakeEntityService.Setup(x => x.Add(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>()))
                .Callback(() => Console.WriteLine("fake callback delegate log"));
            FakeEntityService.Setup(x => x.ToSafeSlug(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>())).Returns("fake-slug");
        }
        [Fact]
        public async Task GetCategoryByIdAsync_WithValidInputForExistingEntity_ShouldReturnCorrespondentEntity()
        {
            using (var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                dbContext.AddRange(SampleCategoryDataHelper.GetSampleCategoryData());
                dbContext.SaveChanges();
                
                var service = new CategoryService(new StormyRepository<Category>(dbContext),null);
                //Act
                var entity = await service.GetCategoryByIdAsync(1);
                //Assert
                Assert.Equal(1, entity.Id);
            }
        }
        [Fact]
        public async Task GetAllCategoriesAsync_NoInput_ShouldReturnAllNonDeletedEntitiesOnDatabase()
        {
            using (var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                //Arrange
                dbContext.AddRange(SampleCategoryDataHelper.GetSampleCategoryData());
                dbContext.SaveChanges();
                
                var service = new CategoryService(new StormyRepository<Category>(dbContext), null);
                //Act
                var entities = await service.GetAllCategoriesAsync();
                //Assert
                Assert.Equal(2,entities.Count);                
            }
        }                 
        [Fact]
        public async Task AddCategoryAsync_WithValidEntry_ShouldCreateNewEntryOnDatabase()
        {
            using (var dbContext = new StormyDbContext(DbContextHelper.GetDbOptions()))
            {
                //Arrange                
                var service = new CategoryService(new StormyRepository<Category>(dbContext),FakeEntityService.Object);                
                //Act
                await service.AddAsync(SampleCategoryDataHelper.GetSingleCategoryData());
                var entities = await service.GetAllCategoriesAsync();
                //Assert
                Assert.Equal(2, entities.Count);                
            }
        }
        
        //[Fact]
        //public async Task Get
    }
}
