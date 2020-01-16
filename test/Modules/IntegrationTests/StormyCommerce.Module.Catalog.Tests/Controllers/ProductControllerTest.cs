using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Logging;
using StormyCommerce.Module.Catalog.Controllers;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Catalog.Models.Requests;
using StormyCommerce.Module.Catalog.Models.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Module.Catalog.Tests.Catalog
{
    public class ProductControllerTests
    {    
        private readonly ProductController _productController;

        public ProductControllerTests(IStormyProductService productService,IMapper mapper,IAppLogger<ProductController> logger)
        {            
            _productController = new ProductController(productService,mapper,null,logger);
        }
        [Fact]        
        public async Task SearchProducts_ReceivesSearchPattern_ShouldReturnAllProductsWithGivenPattern()
        {
            //When            
            string searchPattern = "e";
            var response = await _productController.SearchProducts(searchPattern);    
            var result = response.Value as List<ProductSearchResponse>;
            //Then            
            Assert.True(result.All(p => p.ProductName.Contains(searchPattern) ||
            p.ShortDescription.Contains(searchPattern)));
        }        

        [Fact]
        public void GetNumberOfProducts_NoInput_ReturnTotalCountOfProductsOnDatabase()
        {
            //Act
            var productsCount = _productController.GetNumberOfProducts();
            //Assert
            Assert.True(productsCount > 0);
        }
        [Fact]
        public async Task GetProductOverviewAsync_IdEqual1_ReturnMinifiedVersionOfProductDto()
        {
            // Arrange
            long id = 1;

            // Act
            var result = await _productController.GetProductOverviewAsync(id);

            // Assert
            Assert.Equal(1, result.Value.Id);
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
            Assert.NotNull(result);
            //Yeah, the method start from zero, so the final result is 16, instead of 15
            Assert.Equal(15, result.Value.Count);
        }

        [Fact]
        public async Task GetProductById_GivenIdEqual1_ReturnEntityWithGivenId()
        {
            // Arrange
            long id = 1;

            // Act
            var result = (await _productController.GetProductById(id));

            //Assert
            Assert.Equal(1, result.Value.Id);
        }

        [Fact]
        public async Task CreateProduct_GivenModelIsValidDto_CreateNewEntryOnDatabase()
        {
            // Arrange
            //var model = GetCreateProductRequestModel(Api.Framework.Seeders.ProductSeed().FirstOrDefault());            
            var model = new CreateProductRequest();
            // Act
            var result = await _productController.CreateProduct(model);
            // Assert
            var objResult = Assert.IsAssignableFrom<OkResult>(result);
            Assert.Equal(200, objResult.StatusCode);
        }
        private CreateProductRequest GetCreateProductRequestModel(Product product)
        {
            return new CreateProductRequest{
                Description = product.Description,
                ShortDescription = product.Description,
                Sku = product.Sku,
                Diameter = product.Diameter,
                Height = product.Height,
                Length = product.Length,
                Width = product.Width,                
                Name = product.Name,
                Brand = product.Brand,                                
                UnitPrice = product.Price,
                UnitWeight = product.UnitWeight,
                StockQuantity = product.StockQuantity,                
                ThumbnailImage = product.ThumbnailImage.FileName,                
            };
        }
    }
}
