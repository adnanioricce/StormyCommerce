using Moq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Tests.Helpers;
using StormyCommerce.Infraestructure.Data.Repositories;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Catalog
{
    public class EntityServiceTests : IDisposable
    {
        private MockRepository mockRepository;

        private Mock<IStormyRepository<Entity>> mockStormyRepository;

        public EntityServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockStormyRepository = this.mockRepository.Create<IStormyRepository<Entity>>();
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }        

        private EntityService CreateService()
        {
            var dbContext = DbContextHelper.GetDbContext();
            return new EntityService(new StormyRepository<Entity>(dbContext));
        }
        private EntityService CreateServiceWithData()
        {
            var dbContext = DbContextHelper.GetDbContext();
            dbContext.AddRange(EntityDataSeeder.GetEntitySeedList());
            dbContext.SaveChanges();
            return new EntityService(new StormyRepository<Entity>(dbContext));
        }
        //How do I Test this?
        [Fact]
        public void ToSafeSlug_SlugEqualWomanEntityIdEqualOneEntityTypeIdEqualCategory_ASlugWithTheGivenSlugStringAndCategory()
        {
            // Arrange
            var service = this.CreateService();
            string slug = "woman";
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            var result = service.ToSafeSlug(slug,entityId,entityTypeId);
            var storedSlug = service.Get(entityId, entityTypeId);

            // Assert
            Assert.True(String.Equals(result,storedSlug.Slug,StringComparison.Ordinal));            
            Assert.NotNull(result);
        }

        [Fact]
        public void Get_entityIdEqual1AndEntityTypeIdEqualCategory_ReturnEntryEqualEntityIdAndEntityTypeId()
        {
            // Arrange
            var service = this.CreateServiceWithData();
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            var result = service.Get(entityId,entityTypeId);

            // Assert
            Assert.Equal(entityId, result.EntityId);
            Assert.True(String.Equals(entityTypeId,result.EntityTypeId,StringComparison.Ordinal));
            Assert.True(!String.IsNullOrEmpty(result.Slug));
        }

        [Fact]
        public void Add_SlugForNameWoman_ReturnASlugWithCategoryAndNameOfEntity()
        {
            // Arrange
            var service = this.CreateService();
            string name = "Woman";
            string slug = "woman";
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            service.Add(
                name,
                slug,
                entityId,
                entityTypeId);
            var result = service.Get(entityId,entityTypeId);
            // Assert
            Assert.Equal(entityId,result.EntityId);
            Assert.Equal(entityTypeId,result.EntityTypeId);
        }

        [Fact]
        public void Update_NewNameAndSlugEntityIdEqual1_EditEntryWithGivenEntityId()
        {
            // Arrange
            var service = this.CreateServiceWithData();
            string newName = "Men";
            string newSlug = "men";
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            service.Update(
                newName,
                newSlug,
                entityId,
                entityTypeId);
            var result = service.Get(entityId,entityTypeId);
            // Assert
            Assert.Equal(entityId,result.EntityId);
            Assert.Equal(entityTypeId,result.EntityTypeId);
        }

        [Fact]
        public async Task DeleteAsync_EntityIdEqualOneAndEntityTypeEqualCategory_ShouldDeleteEntryWithGivenValues()
        {
            // Arrange
            var service = this.CreateServiceWithData();
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            await service.DeleteAsync(
                entityId,
                entityTypeId);
            var result = service.Get(entityId,entityTypeId);
            // Assert
            Assert.Null(result);
        }
    }
}
