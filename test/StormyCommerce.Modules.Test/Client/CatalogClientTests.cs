using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Moq;
using SimplCommerce.WebHost;
using StormyCommerce.Api.Client.Catalog;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest.Client
{
    public class CatalogClientTests : IClassFixture<WebApplicationFactory<Startup>>,IDisposable
    {
        private MockRepository mockRepository;
        private HttpClient _client;
        public CatalogClientTests(WebApplicationFactory<Startup> factory)
        {
            // this.mockRepository = new MockRepository(MockBehavior.Strict);  
            _client = factory.CreateClient();          
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private CatalogClient CreateCatalogClient()
        {
            return new CatalogClient(_client);
        }

        [Fact]
        public async Task CreateCategoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            Category category = Seeders.CategorySeed().First();
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.CreateCategoryAsync(category,cancellationToken);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task CreateProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            Category category = Seeders.CategorySeed().First();
            StormyVendor vendor = Seeders.StormyVendorSeed().First();
            Brand brand = Seeders.BrandSeed().First();            
            StormyProduct _model = Seeders.StormyProductSeed().First();
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);
            //TODO:Create the other entities Separately
            // Act
            var result = await catalogClient.CreateProductAsync(_model,cancellationToken);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task EditCategoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            Category category = Seeders.CategorySeed().First();
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.EditCategoryAsync(category,cancellationToken);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task EditProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();            
            StormyProduct _model = Seeders.StormyProductSeed().First();
            _model.Id = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.EditProductAsync(_model,cancellationToken);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task GetAllAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllAsync(cancellationToken);

            // Assert
            Assert.True(result.Count >= 50);
        }

        [Fact]
        public async Task GetAllProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            long? startIndex = 0;
            long? endIndex = 15;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllProductsAsync(
                startIndex,
                endIndex,
                cancellationToken);

            // Assert
            Assert.True(result.Count <= endIndex && result.Count >= startIndex);
        }

        [Fact]
        public async Task GetAllProductsOnCategoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            int? categoryId = 1;
            int? limit = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllProductsOnCategoryAsync(
                categoryId,
                limit,
                cancellationToken);

            // Assert
            // Assert.Contains(result,f => f.Category.Id == categoryId);
            Assert.True(result.Count <= limit);
        }

        [Fact]
        public async Task GetAllProductsOnHomepageAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            int? limit = 15;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllProductsOnHomepageAsync(
                limit,
                cancellationToken);

            // Assert
            Assert.True(result.Count >= 15);
        }

        [Fact]
        public async Task GetCategoryByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            long? id = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetCategoryByIdAsync(
                id,
                cancellationToken);

            // Assert
            Assert.Equal(id,result.Id);
        }

        [Fact]
        public async Task GetNumberOfProductsInCategoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            var categoryIds = new long[] { 1 };
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetNumberOfProductsInCategoryAsync(
                categoryIds,
                cancellationToken);

            // Assert
            //! this don't seem right
            Assert.True(result >= 1);
        }

        [Fact]
        public async Task GetProductByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            long? id = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetProductByIdAsync(
                id,
                cancellationToken);

            // Assert
            Assert.Equal(id,result.Id);
        }

        [Fact]
        public async Task GetProductOverviewAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = this.CreateCatalogClient();
            long? id = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetProductOverviewAsync(id,cancellationToken);

            // Assert
            Assert.Equal(id,result.Id);
        }
    }
}
