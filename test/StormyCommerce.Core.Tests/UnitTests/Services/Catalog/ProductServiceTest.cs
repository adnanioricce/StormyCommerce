using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Tests.Helpers;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Test.UnitTests.Services.Catalog
{
    public class ProductServiceTest
    {
        private readonly IStormyRepository<StormyProduct> _repository;
        private readonly ProductService _service;

        public ProductServiceTest()
        {
            _repository = RepositoryHelper.GetRepository<StormyProduct>();
            _repository.AddCollectionAsync(Seeders.StormyProductSeed(6));
            Task.WaitAll();
            _service = new ProductService(_repository);
        }

        [Theory]
        [InlineData(1)]
        public async Task GetProductByIdAsync(int id)
        {
            //Act
            var entity = await _service.GetProductByIdAsync(id);
            //Assert
            Assert.Equal(id, entity.Id);
        }

        [Fact]
        public async Task GetProductBySkuAsync()
        {
            var product = await _repository.GetByIdAsync(1);
            //var service = new ProductService(repo);
            //Act
            var entity = await _service.GetProductBySkuAsync(product.SKU);
            //Assert
            Assert.Equal(product.SKU, entity.SKU);
        }

        [Fact]
        public async Task GetListProducts()
        {
            //Act
            var entities = await _service.GetAllProductsDisplayedOnHomepageAsync(6);
            //Assert
            Assert.Equal(6, entities.Count());
        }

        [Theory]
        [InlineData(new long[] { 1, 2, 3, 4, 5, 6 })]
        public async Task GetProductsByIdColletion(long[] ids)
        {
            //Act
            var entities = await _service.GetProductsByIdsAsync(ids);
            //Assert
            //TODO:Change to Assert.Collection
            //TODO:Add more challenging InLineData
            Assert.Equal(1, entities.First(entity => entity.Id == 1).Id);
            Assert.Equal(2, entities.First(entity => entity.Id == 2).Id);
            Assert.Equal(3, entities.First(entity => entity.Id == 3).Id);
            Assert.Equal(4, entities.First(entity => entity.Id == 4).Id);
            Assert.Equal(5, entities.First(entity => entity.Id == 5).Id);
            Assert.Equal(6, entities.First(entity => entity.Id == 6).Id);
        }

        [Fact]
        public async Task GetTotalStockQuantity()
        {
            //Arrange
            var repo = RepositoryHelper.GetRepository<StormyProduct>();
            await repo.AddCollectionAsync(Seeders.StormyProductSeed(10));
            var service = new ProductService(repo);
            //Act
            var stockQuantity = service.GetTotalStockQuantity();
            //Assert
            Assert.True(stockQuantity >= 0 && stockQuantity <= 500);
        }

        [Fact]
        public async Task GetTotalStockQuantityOfProduct()
        {
            //Act
            var stockQuantity = _service.GetTotalStockQuantityOfProduct(await _repository.GetByIdAsync(1));
            //Assert
            Assert.True(stockQuantity >= 0 && stockQuantity <= 10);
        }

        [Fact]
        public void GetNumberOfProductsOfVendorByItsId()
        {
            //Act
            var numberOfProducts = _service.GetNumberOfProductsByVendorId(1);
            //Assert
            Assert.Equal(1, numberOfProducts);
        }

        [Fact]
        public async Task InsertProductAsync()
        {
            //Act
            var sampleProduct = ProductDataSeeder.GetSampleData();
            await _service.InsertProductAsync(sampleProduct);
            var product = await _service.GetProductByIdAsync(sampleProduct.Id);
            //Assert
            Assert.Equal(sampleProduct, product);
            Assert.Equal(sampleProduct.Id, product.Id);
        }

        [Fact]
        public async Task InsertProductsAsync()
        {
            var repo = RepositoryHelper.GetRepository<StormyProduct>();
            var service = new ProductService(repo);
            //Act
            var sampleProducts = Seeders.StormyProductSeed(2);
            //TODO:I think I made a mistake when creating all this...
            sampleProducts.ForEach(p => new StormyProduct(p.ToProductDto(), 50 + p.Id));
            await service.InsertProductsAsync(sampleProducts);
            var products = await service.GetProductsByIdsAsync(sampleProducts
                    .Select(f => f.Id)
                    .ToArray());
            //Assert
            Assert.Equal(sampleProducts, products);
        }
    }
}
