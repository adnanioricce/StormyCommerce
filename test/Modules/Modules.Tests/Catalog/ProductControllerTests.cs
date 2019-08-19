using AutoMapper;
using Moq;
using SimplCommerce.Module.SampleData;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Infraestructure.Helpers;
using StormyCommerce.Module.Catalog.Area.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Mocks;
using Xunit;

namespace StormyCommerce.Modules.Test.Area.Controllers
{
    public class ProductControllerTests
    {
	    	    
        //! I think this will fail, define some logic to the mock
        private ProductController CreateController() => new ProductController(ServiceTestFactory.GetProductService(), new Mock<IMapper>().Object);
        [Fact]
        public async Task GetProductOverviewAsync_IdEqual1_ReturnMinifiedVersionOfProductDto()
        {
            // Arrange
            var productController = CreateController();
            long id = 1;

            // Act
            var result = await productController.GetProductOverviewAsync(id);

            // Assert
            Assert.Equal(1,result.Value.Id);
        }

        [Fact]
        public async Task GetAllProducts_StartIndexEqual1AndEndIndexEqual15_ReturnEntitiesBetweenThesesValues()
        {
            // Arrange
            var productController = CreateController();
            long startIndex = 1;
            long endIndex = 15;

            // Act
            var result = await productController.GetAllProducts(startIndex,endIndex);

            // Assert
            Assert.Equal(15,result.Value.Count);
        }

        [Fact]
        public async Task GetAllProductsOnHomepage_LimitEqual15_ReturnProductsWhileRankingIsLessThanLimit()
        {
            // Arrange
            var productController = CreateController();
            int limit = 15;

            // Act
            var result = (await productController.GetAllProductsOnHomepage(limit));

            // Assert            
            Assert.Equal(limit,result.Value.Count);
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
            Assert.Equal(id,result.Value.Id);
        }

        [Fact]
        public async Task CreateProduct_GivenModelIsValidDto_CreateNewEntryOnDatabase()
        {
            // Arrange
            var productController = CreateController();
            var product = Seeders.StormyProductSeed(1).FirstOrDefault();

            var model = new ProductDto(product);
            

            // Act
            await productController.CreateProduct(model);
            var createdEntry = productController.GetProductById(model.Id);
            // Assert
            Assert.Equal(model.Id,createdEntry.Id);
        }
    }
}
