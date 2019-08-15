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
	    	    
        private ProductController CreateController() => new ProductController(ServiceTestFactory.GetProductService(), ServiceTestFactory.GetCategoryService());
        [Fact]
        public async Task GetProductOverviewAsync_IdEqual1_ReturnMinifiedVersionOfProductDto()
        {
            // Arrange
            var productController = CreateController();
            long id = 1;

            // Act
            ProductOverviewDto result = await productController.GetProductOverviewAsync(id);

            // Assert
            Assert.Equal(1,result.Id);
        }

        [Fact]
        public async Task GetAllProducts_StartIndexEqual1AndEndIndexEqual15_ReturnEntitiesBetweenThesesValues()
        {
            // Arrange
            var productController = CreateController();
            long startIndex = 1;
            long endIndex = 15;

            // Act
            List<ProductDto> result = await productController.GetAllProducts(startIndex,endIndex);

            // Assert
            Assert.Equal(15,result.Count);
        }

        [Fact]
        public async Task GetAllProductsOnHomepage_LimitEqual15_ReturnProductsWhileRankingIsLessThanLimit()
        {
            // Arrange
            var productController = CreateController();
            int limit = 15;

            // Act
            var result = await productController.GetAllProductsOnHomepage(limit);

            // Assert
            Assert.Equal(limit,result.Count);
        }

        [Fact]
        public async Task GetProductById_GivenIdEqual1_ReturnEntityWithGivenId()
        {
            // Arrange
            var productController = CreateController();
            long id = 1;

            // Act
            var result = await productController.GetProductById(id);

            // Assert
            Assert.Equal(id,result.Id);
        }

        [Fact]
        public async Task CreateProduct_GivenModelIsValidDto_CreateNewEntryOnDatabase()
        {
            // Arrange
            var productController = CreateController();
            var model = new ProductDto 
            {

            }

            // Act
            await productController.CreateProduct(_model);
            var createdEntry = productController.GetProductById(model.Id);
            // Assert
            Assert.Equal(model.Id,createdEntry.Id);
        }
    }
}
