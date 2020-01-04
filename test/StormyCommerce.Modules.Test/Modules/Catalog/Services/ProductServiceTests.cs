using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Api.Framework.Extensions;

using StormyCommerce.Core.Interfaces;

using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Module.Catalog.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Services.Catalog
{
    public class ProductServiceTests
    {
        private readonly IProductService service;
        public ProductServiceTests(IProductService productService)
        {
            service = productService;
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
            IList<long> categoryIds = null;

            // Act
            var result = service.GetNumberOfProductsInCategory(categoryIds);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public async Task GetProductByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long productId = 1;

            // Act
            var result = await service.GetProductByIdAsync(productId);

            // Assert
            Assert.Equal(productId, result.Id);
        }

        [Fact]
        public async Task SearchProductsBySearchPattern_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string searchPattern = "er";

            // Act
            var result = await service.SearchProductsBySearchPattern(searchPattern);

            // Assert
            Assert.True(result.All(prop => prop.ProductName.Contains(searchPattern) || prop.ShortDescription.Contains(searchPattern)));
        }

        [Fact]
        public async Task GetProductBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string sku = null;

            // Act
            var result = await service.GetProductBySkuAsync(sku);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetProductsByIdsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long[] productIds = { 1,2};

            // Act
            var result = await service.GetProductsByIdsAsync(productIds);

            // Assert
            Assert.Equal(2,result.Count);
        }

        [Fact]
        public async Task GetProductByNameAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string productName = null;

            // Act
            var result = await service.GetProductByNameAsync(productName);

            // Assert
            Assert.True(false);
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
            Product product = null;

            // Act
            var result = service.GetTotalStockQuantityOfProduct(product);

            // Assert
            Assert.True(false);
        }                

        [Fact]
        public async Task DeleteProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Product product = null;

            // Act
            await service.DeleteProductAsync(product);

            // Assert
            Assert.True(false);
        }      
        [Fact]
        public async Task InsertProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Product product = null;

            // Act
            await service.InsertProductAsync(product);

            // Assert
            Assert.True(product.Id != 0);
            Assert.NotNull(product.Brand);            
            Assert.NotNull(product.Categories);
        }

        [Fact]
        public async Task InsertProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            IList<Product> products = null;

            // Act
            await service.InsertProductsAsync(products);

            // Assert
            Assert.True(products.All(p => p.Id != 0));
            Assert.True(products.All(p => p.Brand != null));
            Assert.True(products.All(p => p.Categories != null && p.Categories.Count > 0));            
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
