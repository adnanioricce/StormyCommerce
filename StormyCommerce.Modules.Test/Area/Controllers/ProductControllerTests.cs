using AutoMapper;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Area.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Test.Area.Controllers
{
    public class ProductControllerTests
    {
        [Fact]
        public async Task GetProductOverviewAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var productController = new ProductController(null, null);
            long id = 0;

            // Act
            var result = await productController.GetProductOverviewAsync(
                id);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllProducts_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var productController = new ProductController(null,null);
            long startIndex = 0;
            long endIndex = 0;

            // Act
            var result = await productController.GetAllProducts(
                startIndex,
                endIndex);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllProductsOnHomepage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var productController = new ProductController(null, null);
            int limit = 0;

            // Act
            var result = await productController.GetAllProductsOnHomepage(
                limit);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetProductById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var productController = new ProductController(null,null);
            long id = 0;

            // Act
            var result = await productController.GetProductById(
                id);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CreateProduct_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var productController = new ProductController(null, null);
            ProductDto _model = null;

            // Act
            await productController.CreateProduct(
                _model);

            // Assert
            Assert.True(false);
        }
    }
}
