// using Microsoft.AspNetCore.Mvc.Testing;
// using Microsoft.AspNetCore.TestHost;
// using Moq;
// using SimplCommerce.WebHost;
// using StormyCommerce.Api.Client.Catalog;
// using StormyCommerce.Api.Framework.Extensions;
// 
// 
// using StormyCommerce.Core.Entities.Vendor;
// using StormyCommerce.Core.Models.Requests;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Threading;
// using System.Threading.Tasks;
// using Xunit;

// namespace StormyCommerce.Modules.IntegrationTest.Client
// {
//     public class CatalogClientTests : IClassFixture<WebApplicationFactory<Startup>>,IDisposable
//     {
//         private MockRepository mockRepository;
//         private HttpClient _client;
//         public CatalogClientTests(WebApplicationFactory<Startup> factory)
//         {
//             // factory.WithWebHostBuilder((config) => {                                
//             // })
//             _client = factory.CreateClient();          
//         }

//         public void Dispose()
//         {
//             this.mockRepository.VerifyAll();
//         }

//         private CatalogClient CreateCatalogClient()
//         {
//             return new CatalogClient(_client);
//         }

//         [Fact]
//         public async Task CreateCategoryAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             Category category = Seeders.CategorySeed().First();
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.CreateCategoryAsync(category,cancellationToken);

//             // Assert
//             Assert.True(result.Success);
//         }

//         [Fact]
//         public async Task CreateProductAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();            
//             Product _model = Seeders.ProductSeed().First();
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);            
//             // Act
//             var result = await catalogClient.CreateProductAsync(GetCreateProductRequestModel(_model),cancellationToken);
//             // Assert
//             Assert.True(result.Success);
//         }

//         [Fact]
//         public async Task EditCategoryAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             Category category = Seeders.CategorySeed().First();
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.EditCategoryAsync(category,cancellationToken);

//             // Assert
//             Assert.True(result.Success);
//         }

//         [Fact]
//         public async Task EditProductAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();            
//             Product _model = Seeders.ProductSeed().First();
//             _model.Id = 1;
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.EditProductAsync(_model,cancellationToken);

//             // Assert
//             Assert.True(result.Success);
//         }

//         [Fact]
//         public async Task GetAllAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetAllAsync(cancellationToken);

//             // Assert
//             Assert.True(result.Count >= 50);
//         }

//         [Fact]
//         public async Task GetAllProductsAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             long? startIndex = 0;
//             long? endIndex = 15;
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetAllProductsAsync(
//                 startIndex,
//                 endIndex,
//                 cancellationToken);

//             // Assert
//             Assert.True(result.Count <= endIndex && result.Count >= startIndex);
//         }

//         [Fact]
//         public async Task GetAllProductsOnCategoryAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             int? categoryId = 1;
//             int? limit = 1;
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetAllProductsOnCategoryAsync(
//                 categoryId,
//                 limit,
//                 cancellationToken);

//             // Assert
//             // Assert.Contains(result,f => f.Category.Id == categoryId);
//             Assert.True(result.Count <= limit);
//         }

//         [Fact]
//         public async Task GetAllProductsOnHomepageAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             int? limit = 15;
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetAllProductsOnHomepageAsync(
//                 limit,
//                 cancellationToken);

//             // Assert
//             Assert.True(result.Count >= 15);
//         }

//         [Fact]
//         public async Task GetCategoryByIdAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             long? id = 1;
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetCategoryByIdAsync(
//                 id,
//                 cancellationToken);

//             // Assert
//             Assert.Equal(id,result.Id);
//         }

//         [Fact]
//         public async Task GetNumberOfProductsInCategoryAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             var categoryIds = new long[] { 1 };
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetNumberOfProductsInCategoryAsync(
//                 categoryIds,
//                 cancellationToken);

//             // Assert
//             //! this don't seem right
//             Assert.True(result >= 1);
//         }

//         [Fact]
//         public async Task GetProductByIdAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             long? id = 1;
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetProductByIdAsync(
//                 id,
//                 cancellationToken);

//             // Assert
//             Assert.Equal(id,result.Id);
//         }

//         [Fact]
//         public async Task GetProductOverviewAsync_StateUnderTest_ExpectedBehavior()
//         {
//             // Arrange
//             var catalogClient = this.CreateCatalogClient();
//             long? id = 1;
//             CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

//             // Act
//             var result = await catalogClient.GetProductOverviewAsync(id,cancellationToken);

//             // Assert
//             Assert.Equal(id,result.Id);
//         }
//         private CreateProductRequest GetCreateProductRequestModel(Product product)
//         {
//             return new CreateProductRequest{
//                 Description = product.Description,
//                 ShortDescription = product.Description,
//                 SKU = product.SKU,
//                 Diameter = product.Diameter,
//                 Height = product.Height,
//                 Length = product.Length,
//                 Width = product.Width,
//                 AvailableSizes = "P,M,G,GG",
//                 ProductCost = product.ProductCost,
//                 ProductName = product.ProductName,
//                 Brand = product.Brand,                
//                 Vendor = product.Vendor,
//                 QuantityPerUnity = product.QuantityPerUnity,
//                 UnitPrice = product.UnitPrice,
//                 UnitWeight = product.UnitWeight,
//                 UnitsInStock = product.UnitsInStock,
//                 ProductAvailable = true,
//                 ThumbnailImage = product.ThumbnailImage,
//                 Medias = product.Medias,
//                 Links = product.Links.Select(p => p.ToProductLinkDto()).ToList(),
//                 Note = product.Note,        
//                 Discount = product.Discount,
//             };
//         }
//     }
// }
