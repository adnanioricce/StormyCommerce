using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Module.Catalog.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Module.Catalog.UnitTests.Services
{
    public class StormyProductServiceTests
    {
        [Fact]
        public async Task GetAllProductsByCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            long categoryId = 0;
            int limit = 0;

            // Act
            var result = await service.GetAllProductsByCategory(
                categoryId,
                limit);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            long startIndex = 0;
            long endIndex = 0;

            // Act
            var result = await service.GetAllProductsAsync(
                startIndex,
                endIndex);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetNumberOfProducts_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);

            // Act
            var result = service.GetNumberOfProducts();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetNumberOfProductsByVendorId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            int vendorId = 0;

            // Act
            var result = service.GetNumberOfProductsByVendorId(
                vendorId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetNumberOfProductsInCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            IList categoryIds = null;

            // Act
            var result = service.GetNumberOfProductsInCategory(
                categoryIds);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetProductByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            long productId = 0;

            // Act
            var result = await service.GetProductByIdAsync(
                productId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SearchProductsBySearchPattern_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            string searchPattern = null;

            // Act
            var result = await service.SearchProductsBySearchPattern(
                searchPattern);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetProductBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            string sku = null;

            // Act
            var result = await service.GetProductBySkuAsync(
                sku);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetProductsByIdsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            IEnumerable productIds = null;

            // Act
            var result = await service.GetProductsByIdsAsync(
                productIds);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetProductsBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            IEnumerable skuArray = null;

            // Act
            var result = await service.GetProductsBySkuAsync(
                skuArray);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetTotalStockQuantity_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);

            // Act
            var result = service.GetTotalStockQuantity();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetTotalStockQuantityOfProduct_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            long productId = 0;

            // Act
            var result = service.GetTotalStockQuantityOfProduct(
                productId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteProduct_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            Product product = null;

            // Act
            await service.DeleteProduct(
                product);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteProducts_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            IList products = null;

            // Act
            await service.DeleteProducts(
                products);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            Product product = null;

            // Act
            await service.DeleteProductAsync(
                product);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            IList products = null;

            // Act
            await service.DeleteProductsAsync(
                products);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task InsertProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            Product product = null;

            // Act
            await service.InsertProductAsync(
                product);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task InsertProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            IList products = null;

            // Act
            await service.InsertProductsAsync(
                products);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            Product product = null;

            // Act
            await service.UpdateProductAsync(
                product);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(TODO, TODO);
            IList products = null;

            // Act
            await service.UpdateProductsAsync(
                products);

            // Assert
            Assert.True(false);
        }
    }
}
