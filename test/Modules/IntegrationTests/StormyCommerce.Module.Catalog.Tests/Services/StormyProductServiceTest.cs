using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Module.Catalog.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Module.Catalog.Tests.Services.Catalog
{
    public class ProductServiceTests
    {
        private readonly IStormyProductService service;
        private readonly IRepository<Product> _productRepository;
        public ProductServiceTests(IStormyProductService productService,IRepository<Product> productRepository)
        {
            service = productService;
            _productRepository = productRepository;
        }
        [Fact]
        public async Task GetAllProductsByCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            int categoryId = 1;
            int limit = 3;

            // Act
            var result = await service.GetAllProductsByCategory(categoryId,limit);

            // Assert
            Assert.True(result.Value.Count <= limit);
        }

        [Fact]
        public async Task GetAllProductsDisplayedOnHomepageAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            int limit = 5;

            // Act
            var result = await service.GetAllProductsDisplayedOnHomepageAsync(limit);

            // Assert
            Assert.True(result.Count() <= limit);
        }

        [Fact]
        public async Task GetAllProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long startIndex = 1;
            long endIndex = 15;

            // Act
            var result = await service.GetAllProductsAsync(startIndex,endIndex);

            // Assert
            Assert.True(result.Count() > startIndex && result.Count() <= endIndex);
        }        

        [Fact]
        public void GetNumberOfProducts_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            

            // Act
            var result = service.GetNumberOfProducts();

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void GetNumberOfProductsByVendorId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            int vendorId = 1;

            // Act
            var result = service.GetNumberOfProductsByVendorId(vendorId);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void GetNumberOfProductsInCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            IList<long> categoryIds = new List<long>{
                1
            };

            // Act
            var result = service.GetNumberOfProductsInCategory(categoryIds);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public async Task GetProductByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Product product = ProductSeeder.InsertProductSeed();
            _productRepository.Add(product);            

            // Act
            var result = await service.GetProductByIdAsync(product.Id);

            // Assert
            Assert.Equal(product.Id, result.Id);
        }

        [Fact]
        public async Task SearchProductsBySearchPattern_StateUnderTest_ExpectedBehavior()
        {
            // Arrange        
            Product product = ProductSeeder.InsertProductSeed();    
            _productRepository.Add(product);
            string searchPattern = product.Name.Substring(product.Name.Length-3);

            // Act
            var result = await service.SearchProductsBySearchPattern(searchPattern);

            // Assert
            Assert.True(result.All(prop => prop.Name.Contains(searchPattern) || prop.ShortDescription.Contains(searchPattern)));
        }

        [Fact]
        public async Task GetProductBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Product product = ProductSeeder.InsertProductSeed(); 
            _productRepository.Add(product);                        

            // Act
            var result = await service.GetProductBySkuAsync(product.Sku);

            // Assert
            Assert.Equal(product.Sku,result.Sku);
        }

        [Fact]
        public async Task GetProductsByIdsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var products = new List<Product>{
                ProductSeeder.InsertProductSeed(),ProductSeeder.InsertProductSeed()
            };            

            // Act
            var result = await service.GetProductsByIdsAsync(products.Select(p => p.Id));

            // Assert
            Assert.Equal(2,result.Count);
        }

        [Fact]
        public async Task GetProductByNameAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange           
            Product product = ProductSeeder.InsertProductSeed(); 
            _productRepository.Add(product);            

            // Act
            var result = await service.GetProductByNameAsync(product.Name);

            // Assert
            Assert.Equal(product.Name,result.Name);
        }

        [Fact]
        public async Task GetProductsBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string[] skuArray = null;
            int vendorId = 0;

            // Act
            var result = await service.GetProductsBySkuAsync(
                skuArray,
                vendorId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetTotalStockQuantity_StateUnderTest_ExpectedBehavior()
        {            
            // Act
            var result = service.GetTotalStockQuantity();

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void GetTotalStockQuantityOfProduct_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long productId = 1;

            // Act
            var result = service.GetTotalStockQuantityOfProduct(productId);

            // Assert
            Assert.True(result >= 0);
        }

        [Fact]
        public void GetTotalStockQuantityOfProduct_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange                        
            long productId = 1;
            // Act
            var result = service.GetTotalStockQuantityOfProduct(productId);

            // Assert
            Assert.True(result > 0);
        }                

        [Fact]
        public async Task DeleteProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                   
            long productId = 8;     
            Product product = await _productRepository.GetByIdAsync(productId);

            // Act
            await service.DeleteProductAsync(product);

            // Assert
            Assert.Null(await _productRepository.GetByIdAsync(productId));
        }      
        [Fact]
        public async Task InsertProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Product product = ProductSeeder.InsertProductSeed();

            // Act
            await service.InsertProductAsync(product);

            // Assert
            Assert.True(product.Id != 0 || product.Id > 0);           
        }

        [Fact]
        public async Task InsertProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            IList<Product> products = new List<Product>{
                ProductSeeder.InsertProductSeed(),
                ProductSeeder.InsertProductSeed()
            };

            // Act
            await service.InsertProductsAsync(products);

            // Assert
            Assert.True(products.All(p => p.Id != 0 && p.Id > 0));                      
        }

        [Fact]
        public async Task UpdateProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Product product = null;

            // Act
            await service.UpdateProductAsync(product);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            IList<Product> products = null;

            // Act
            await service.UpdateProductsAsync(products);

            // Assert
            Assert.True(false);
        }
    }
}
