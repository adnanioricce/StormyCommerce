using Moq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Services.Catalog;
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
            return new EntityService(
                this.mockStormyRepository.Object);
        }

        [Fact]
        public void ToSafeSlug_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string slug = null;
            long entityId = 0;
            string entityTypeId = null;

            // Act
            var result = service.ToSafeSlug(
                slug,
                entityId,
                entityTypeId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long entityId = 0;
            string entityTypeId = null;

            // Act
            var result = service.Get(
                entityId,
                entityTypeId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string name = null;
            string slug = null;
            long entityId = 0;
            string entityTypeId = null;

            // Act
            service.Add(
                name,
                slug,
                entityId,
                entityTypeId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Update_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string newName = null;
            string newSlug = null;
            long entityId = 0;
            string entityTypeId = null;

            // Act
            service.Update(
                newName,
                newSlug,
                entityId,
                entityTypeId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long entityId = 0;
            string entityTypeId = null;

            // Act
            await service.DeleteAsync(
                entityId,
                entityTypeId);

            // Assert
            Assert.True(false);
        }
    }
}
