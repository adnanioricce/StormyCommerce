using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Tests.Helpers;
using System;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Catalog
{
    public class EntityServiceTests
    {
        private readonly IStormyRepository<Entity> _repository;
        private readonly IEntityService _service;

        public EntityServiceTests()
        {
            _repository = RepositoryHelper.GetRepository<Entity>();
            _repository.AddCollectionAsync(EntityDataSeeder.GetEntitySeedList());
            Task.WaitAll();
            _service = new EntityService(_repository);
        }

        //How do I Test this?
        [Fact]
        public void ToSafeSlug_SlugEqualWomanEntityIdEqualOneEntityTypeIdEqualCategory_ASlugWithTheGivenSlugStringAndCategory()
        {
            // Arrange
            string slug = "woman";
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            var result = _service.ToSafeSlug(slug, entityId, entityTypeId);
            var storedSlug = _service.Get(entityId, entityTypeId);

            // Assert
            Assert.Equal(result, storedSlug.Slug);
            Assert.NotNull(result);
        }

        [Fact]
        public void Get_entityIdEqual1AndEntityTypeIdEqualCategory_ReturnEntryEqualEntityIdAndEntityTypeId()
        {
            // Arrange
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            var result = _service.Get(entityId, entityTypeId);

            // Assert
            Assert.Equal(entityId, result.EntityId);
            Assert.Equal(entityTypeId, result.EntityTypeId);
            Assert.True(!String.IsNullOrEmpty(result.Slug));
        }

        [Fact]
        public void Add_SlugForNameWoman_ReturnASlugWithCategoryAndNameOfEntity()
        {
            // Arrange
            string name = "Woman";
            string slug = "woman";
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            _service.Add(name, slug, entityId, entityTypeId);
            var result = _service.Get(entityId, entityTypeId);
            // Assert
            Assert.Equal(entityId, result.EntityId);
            Assert.Equal(entityTypeId, result.EntityTypeId);
        }

        [Fact]
        public void Update_NewNameAndSlugEntityIdEqual1_EditEntryWithGivenEntityId()
        {
            // Arrange
            string newName = "Men";
            string newSlug = "men";
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            _service.Update(
                newName,
                newSlug,
                entityId,
                entityTypeId);
            var result = _service.Get(entityId, entityTypeId);
            // Assert
            Assert.Equal(entityId, result.EntityId);
            Assert.Equal(entityTypeId, result.EntityTypeId);
        }

        [Fact]
        public async Task DeleteAsync_EntityIdEqualOneAndEntityTypeEqualCategory_ShouldDeleteEntryWithGivenValues()
        {
            // Arrange
            long entityId = 1;
            string entityTypeId = "Category";

            // Act
            await _service.DeleteAsync(
                entityId,
                entityTypeId);
            var result = _service.Get(entityId, entityTypeId);
            // Assert
            Assert.Null(result);
        }
    }
}
