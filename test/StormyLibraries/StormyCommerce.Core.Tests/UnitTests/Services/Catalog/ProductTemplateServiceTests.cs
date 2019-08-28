using Moq;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Services.Catalog;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Catalog
{
    public class ProductTemplateServiceTests : IDisposable
    {
        private MockRepository mockRepository;

        private Mock<IStormyRepository<ProductTemplate>> mockStormyRepositoryProductTemplate;
        private Mock<IStormyRepository<ProductAttribute>> mockStormyRepositoryProductAttribute;
        private Mock<IProductTemplateProductAttributeRepository> mockProductTemplateProductAttributeRepository;

        public ProductTemplateServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockStormyRepositoryProductTemplate = this.mockRepository.Create<IStormyRepository<ProductTemplate>>();
            this.mockStormyRepositoryProductAttribute = this.mockRepository.Create<IStormyRepository<ProductAttribute>>();
            this.mockProductTemplateProductAttributeRepository = this.mockRepository.Create<IProductTemplateProductAttributeRepository>();
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private ProductTemplateService CreateService()
        {
            return new ProductTemplateService(
                this.mockStormyRepositoryProductTemplate.Object,
                this.mockStormyRepositoryProductAttribute.Object,
                this.mockProductTemplateProductAttributeRepository.Object);
        }

        [Fact]
        public async Task GetProductTemplateByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long id = 0;

            // Act
            var result = await service.GetProductTemplateByIdAsync(
                id);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CreateProductTemplateAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            ProductTemplate productTemplate = null;

            // Act
            await service.CreateProductTemplateAsync(
                productTemplate);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task EditProductTemplateAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long id = 0;
            ProductTemplate productTemplate = null;

            // Act
            await service.EditProductTemplateAsync(
                id,
                productTemplate);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteProductTemplate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            long id = 0;

            // Act
            await service.DeleteProductTemplate(
                id);

            // Assert
            Assert.True(false);
        }
    }
}
