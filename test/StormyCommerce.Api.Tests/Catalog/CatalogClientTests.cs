using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Api.Client.Catalog;
using StormyCommerce.Api.Framework.Extensions;


using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Requests;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Api.Tests.Catalog
{
    public class CatalogClientTests
    {
        [Fact]
        public async Task CreateCategoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            Category category = null;
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
            var catalogClient = new CatalogClient(Config.BaseUrl);
            var product = new Product();
            CreateProductRequest _model = new CreateProductRequest {
                Brand = product.Brand,
                Categories = product.Categories.ToList(),
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                Discount = product.Discount,
                Diameter = product.Diameter,
                Height = product.Height,
                Width = product.Width,
                Length = product.Length,                
                Price = Price.GetPriceFromCents("R$",product.Price),
                Medias = product.Medias.ToList(),
                Links = product.ProductLinks.ToList(),
                SKU = product.Sku,
                UnitPrice = product.Price,
                UnitsInStock = product.UnitsInStock,
                UnitWeight = product.UnitWeight,
                ProductName = product.ProductName,
                ThumbnailImage = product.ThumbnailImage.FileName,                
                VendorId = 1
            };
            
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.CreateProductAsync(
                _model,
                cancellationToken);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task EditCategoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            Category category = new Category
            {
                Id = 1,
                Description = "",
                DisplayOrder = 0,
                IsDeleted = true,
                ThumbnailImage = new Core.Entities.Media.Media { 
                    FileName = "filename.png",                    
                },
                Slug = "",
                Name = "",
                ParentId = 0,
                ChildrenId = 0,
                IncludeInMenu = false,
                IsPublished = false,
            };
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.EditCategoryAsync(
                category,
                cancellationToken);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task EditProductAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            Product _model = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.EditProductAsync(
                _model,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllAsync(cancellationToken);

            // Assert
            Assert.True(result.Count > 1);
        }

        [Fact]
        public async Task GetAllProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            long? startIndex = 1;
            long? endIndex = 14;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllProductsAsync(
                startIndex,
                endIndex,
                cancellationToken);

            // Assert
            Assert.Equal(14,result.Count);
        }

        [Fact]
        public async Task GetAllProductsOnCategoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            int? categoryId = 1;
            int? limit = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllProductsOnCategoryAsync(
                categoryId,
                limit,
                cancellationToken);

            // Assert
            Assert.Equal(1,result.Count);
        }

        [Fact]
        public async Task GetAllProductsOnHomepageAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            int? limit = 10;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetAllProductsOnHomepageAsync(
                limit,
                cancellationToken);

            // Assert
            Assert.Equal(limit,result.Count);
        }

        [Fact]
        public async Task GetCategoryByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
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
            var catalogClient = new CatalogClient(Config.BaseUrl);
            IEnumerable<long> categoryIds = new long[] { 1 };
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetNumberOfProductsInCategoryAsync(categoryIds,cancellationToken);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public async Task GetProductByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            long? id = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetProductByIdAsync(
                id,
                cancellationToken);

            // Assert
            Assert.Equal(1,result.Id);
        }

        [Fact]
        public async Task GetProductOverviewAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var catalogClient = new CatalogClient(Config.BaseUrl);
            long? id = 1;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await catalogClient.GetProductOverviewAsync(
                id,
                cancellationToken);

            // Assert
            Assert.Equal(id,result.Id);
        }
    }
}
