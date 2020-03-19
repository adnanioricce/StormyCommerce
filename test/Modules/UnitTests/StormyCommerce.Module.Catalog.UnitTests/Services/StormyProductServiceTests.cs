using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Tests;
using StormyCommerce.Module.Catalog.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());

            // Act
            var result = service.GetNumberOfProducts();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetNumberOfProductsByVendorId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
            IList<long> categoryIds = null;

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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
            IEnumerable<long> productIds = null;

            // Act
            var result = await service.GetProductsByIdsAsync(productIds);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetProductsBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
            IEnumerable<string> skuArray = new []{ 
                "",""
            };

            // Act
            var result = await service.GetProductsBySkuAsync(skuArray);

            // Assert
            Assert.True(result.Count >= 1);
        }

        [Fact]
        public void GetTotalStockQuantity_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());

            // Act
            var result = service.GetTotalStockQuantity();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetTotalStockQuantityOfProduct_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var service = new StormyProductService(new FakeRepository<Product>(), new FakeRepository<ProductCategory>());
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
            var repo = new FakeRepository<Product>();
            var service = new StormyProductService(repo, null);
            IList<Product> products = null;

            // Act
            await service.DeleteProducts(products);

            // Assert
            var deletedProducts = await repo.GetAllByIdsAsync(products.Select(p => p.Id));
            Assert.True(deletedProducts.Count == 0);
        }

        [Fact]
        public async Task DeleteProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repo = new FakeRepository<Product>();
            var service = new StormyProductService(repo, null);
            Product product = new Product { };

            // Act
            await service.DeleteProductAsync(product);

            // Assert
            var deletedProduct = repo.Query().FirstOrDefault(p => p.Id == product.Id);
            Assert.Null(deletedProduct);
        }

        [Fact]
        public async Task DeleteProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repo = new FakeRepository<Product>();
            var service = new StormyProductService(repo,null);
            IList<Product> products = new[] {
                new Product()
            };

            // Act
            await service.DeleteProductsAsync(products);

            // Assert
            var deletedProducts = repo.GetAllByIdsAsync(products.Select(p => p.Id));
            Assert.Null(deletedProducts);
        }

        [Fact]
        public async Task InsertProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repo = new FakeRepository<Product>();
            var service = new StormyProductService(repo,null);
            Product product = new Product
            {
            };

            // Act
            await service.InsertProductAsync(product);

            // Assert
            var deletedProduct = repo.Query().FirstOrDefault(p => p.Id == product.Id);
            Assert.Null(deletedProduct);
        }

        [Fact]
        public async Task InsertProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repo = new FakeRepository<Product>();
            var service = new StormyProductService(repo, null);
            IList<Product> products = new[] { 
                new Product()
            };

            // Act
            await service.InsertProductsAsync(products);

            // Assert
            var deletedProducts = repo.GetAllByIdsAsync(products.Select(p => p.Id));
            Assert.Null(deletedProducts);
        }

        [Fact]
        public async Task UpdateProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repo = new FakeRepository<Product>();
            var service = new StormyProductService(repo,null);
            Product product = new Product();

            // Act
            await service.UpdateProductAsync(product);

            // Assert            
            var updatedProduct = repo.Query().FirstOrDefault(p => p.Id == product.Id);
            product = null;
            Assert.Null(updatedProduct);
        }

        [Fact]
        public async Task UpdateProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var repo = new FakeRepository<Product>();
            var service = new StormyProductService(repo,null);
            IList<Product> products = null;

            // Act
            await service.UpdateProductsAsync(products);

            // Assert
            var deletedProduct = repo.GetAllByIdsAsync(products.Select(p => p.Id));
            Assert.Null(deletedProduct);
        }
    }
}
