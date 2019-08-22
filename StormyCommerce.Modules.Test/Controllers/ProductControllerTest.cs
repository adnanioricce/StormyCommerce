using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.SampleData.Extensions;
using SimplCommerce.WebHost;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Area.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class ProductControllerTest : IClassFixture<TestFixture<Startup>>
    {
        private ProductController _productController;        
        public ProductControllerTest(TestFixture<Startup> factory)
        {
            var productService = (IProductService)factory.Server.Host.Services.GetService(typeof(IProductService));
            var _mapper = (IMapper)factory.Server.Host.Services.GetService(typeof(IMapper));
            _productController = new ProductController(productService, _mapper);
        }
        [Fact]
        public async Task GetProductOverviewAsync_IdEqual1_ReturnMinifiedVersionOfProductDto()
        {
            // Arrange                                
            long id = 8;

            // Act
            var result = await _productController.GetProductOverviewAsync(id);

            // Assert
            Assert.Equal(8, result.Value.Id);
        }

        [Fact]
        public async Task GetAllProducts_StartIndexEqual1AndEndIndexEqual15_ReturnEntitiesBetweenThesesValues()
        {
            // Arrange                        
            long startIndex = 1;
            long endIndex = 15;

            // Act
            var result = await _productController.GetAllProducts(startIndex, endIndex);

            // Assert
            Assert.Equal(15, result.Value.Count);
        }

        [Fact]
        public async Task GetAllProductsOnHomepage_LimitEqual15_ReturnProductsWhileRankingIsLessThanLimit()
        {
            // Arrange            
            int limit = 15;

            // Act
            var result = (await _productController.GetAllProductsOnHomepage(limit));

            // Assert            
            var returnResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            var returnedValue = returnResult.Value as List<ProductDto>;
            Assert.Equal(200, returnResult.StatusCode);
            Assert.NotNull(returnedValue);
            Assert.Equal(15,returnedValue.Count);
        }

        [Fact]
        public async Task GetProductById_GivenIdEqual1_ReturnEntityWithGivenId()
        {
            // Arrange            
            long id = 1;

            // Act
            var result = await _productController.GetProductById(id);
            //var returnResult = Assert.IsType<OkObjectResult>(result);
            //var valueResult = Assert.IsType<ProductDto>(result);
            // Assert
            //Assert.Equal(200, returnResult.StatusCode);
            //Assert.NotNull(valueResult);
            Assert.Equal(id, result.Value.Id);
        }

        [Fact]
        public async Task CreateProduct_GivenModelIsValidDto_CreateNewEntryOnDatabase()
        {
            // Arrange            
            var product = Seeders.StormyProductSeed(1).FirstOrDefault();

            var model = new ProductDto(product);
            // Act
            var result = await _productController.CreateProduct(model);
            // Assert            
            var objResult = Assert.IsType<OkResult>(result);
            Assert.Equal(200, objResult.StatusCode);
        }
    }
}
