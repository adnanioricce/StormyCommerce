using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Infrastructure.Logging;
using StormyCommerce.Module.Catalog.Controllers;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Catalog.Models.Requests;
using StormyCommerce.Module.Catalog.Models.Responses;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SimplCommerce.Infrastructure.Data;

namespace StormyCommerce.Module.Catalog.Tests.Catalog
{
    public class ProductControllerTests : IClassFixture<TestBase>
    {    
        private readonly ProductController _productController;        
        private readonly IRepository<Product> _productRepository;
        public ProductControllerTests(IStormyProductService productService,
        IMapper mapper,
        IAppLogger<ProductController> logger,
        IRepository<Product> productRepository)
        {            
            _productController = new ProductController(productService,mapper,null,logger); 
            _productRepository = productRepository;
        }
        [Fact]        
        public async Task SearchProducts_ReceivesSearchPattern_ShouldReturnAllProductsWithGivenPattern()
        {
            //Given 
            Product testProduct = ProductSeeder.InsertProductSeed();
            string searchPattern = testProduct.Name;                        
            _productRepository.Add(testProduct);
            _productRepository.SaveChanges();
            //When                        
            
            var response = await _productController.SearchProducts(searchPattern);    
            var result = response.Value as List<ProductSearchResponse>;
            //Then            
            Assert.True(result.All(p => p.Name.Contains(searchPattern)));
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
            long productId = 1;           
            // Act
            var result = await _productController.GetProductOverviewAsync(productId);

            // Assert
            Assert.Equal(productId, result.Value.Id);
        }

        [Fact]
        public async Task GetAllProducts_StartIndexEqual1AndEndIndexEqual15_ReturnEntitiesBetweenThesesValues()
        {
            // Arrange            
            long startIndex = 2;
            long endIndex = 4;

            // Act
            var products = await _productController.GetAllProducts(startIndex, endIndex);

            // Assert
            Assert.Equal(2,products.Value[0].Id);
            Assert.Equal(3,products.Value[1].Id);
            Assert.Equal(4,products.Value[2].Id);
        }

        [Fact]
        public async Task GetAllProductsOnHomepage_LimitEqual15_ReturnProductsWhileRankingIsLessThanLimit()
        {
            // Arrange
            int limit = 5;

            // Act
            var result = (await _productController.GetAllProductsOnHomepage(limit));
            // Assert
            Assert.NotNull(result);
            //Yeah, the method start from zero, so the final result is 16, instead of 15
            Assert.True(result.Value.Count <= limit && result.Value.Count > 0);
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
            var model = GetCreateProductRequestModel(ProductSeeder.InsertProductSeed());
            // Act
            var result = await _productController.CreateProduct(model);
            // Assert
            var objResult = Assert.IsAssignableFrom<OkResult>(result);
            Assert.Equal(200, objResult.StatusCode);
        }
        private CreateProductRequest GetCreateProductRequestModel(Product product)
        {
            return new CreateProductRequest{
                Name = product.Name,
                MetaTitle = product.MetaTitle,            
                MetaKeywords = product.MetaKeywords,    
                Description = product.Description,
                MetaDescription = product.MetaDescription,
                ShortDescription = product.Description,
                Sku = product.Sku,
                Diameter = product.Diameter,
                Height = product.Height.Value,
                Length = product.Length.Value,
                Width = product.Width.Value,                                
                Brand = product.Brand,                                
                Price = product.Price,
                UnitWeight = product.UnitWeight.Value,
                StockQuantity = product.StockQuantity,                
                ThumbnailImage = product.ThumbnailImage.FileName,                
            };
        }
    }
}
