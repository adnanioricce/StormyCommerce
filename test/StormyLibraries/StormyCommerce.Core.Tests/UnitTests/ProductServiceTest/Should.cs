using System;
using Xunit;
using StormyCommerce.Core.Entities.Catalog.Product;
using System.Threading.Tasks;
using System.Linq;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Module.Catalog.Test.Helpers;
namespace StormyCommerce.Core.Test.UnitTests.ProductService
{
    public class Should    
    {   
        [Theory]
        [InlineData(1)]
        public async Task GetProductByIdAsync(int id)
        {
            //?this can give a lot of exceptions, should I throw something
            //Arrange
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {
                dbContext.AddRange(SampleDataHelpers.GetListData());
                dbContext.SaveChanges();                
                // var entityService = new Mock<EntityService>(new Mock<IStormyRepository<Entity>>().Object,new Mock<IMediator>().Object);                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act
                var entity = await service.GetProductByIdAsync(id);
                //Assert
                Assert.Equal(id, entity.Id);
            }            
        }    
        [Theory]
        [InlineData("33E386EE-40A9-4AAA-9FA4-E0A196DC10ED")]
        public async Task GetProductBySkuAsync(string sku)
        {
            //Arrange 
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {
                dbContext.AddRange(SampleDataHelpers.GetListData());
                dbContext.SaveChanges();                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act
                var entity = await service.GetProductBySkuAsync(sku);
                //Assert
                Assert.Equal(sku, entity.SKU);
            }  
        }
        [Fact]
        public async Task GetListProducts()
        {
            //Arrange 
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {
                dbContext.AddRange(SampleDataHelpers.GetListData());
                dbContext.SaveChanges();                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act
                var entities = await service.GetAllProductsDisplayedOnHomepageAsync(6);
                //Assert
                Assert.Equal(6, entities.Count());
            }            
        }

        [Theory]
        [InlineData(new long[] { 1, 2, 3, 4, 5, 6 })]
        public async Task GetProductsByIdColletion(long[] ids)
        {
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {
                dbContext.AddRange(SampleDataHelpers.GetListData());
                dbContext.SaveChanges();                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act
                var entities = await service.GetProductsByIdsAsync(ids);
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
        }        
        [Fact]
        public void GetTotalStockQuantity()
        {
            //Arrange 
            using(var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {
                dbContext.AddRangeAsync(SampleDataHelpers.GetListData());
                dbContext.SaveChanges();                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act 
                var stockQuantity = service.GetTotalStockQuantity();
                //Assert 
                Assert.Equal(58, stockQuantity);
            }
        }
        [Fact]
        public void GetTotalStockQuantityOfProduct()
        {            
            //Arrange 
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {
                var product = SampleDataHelpers.GetSampleData();
                dbContext.AddAsync(product);
                dbContext.SaveChanges();                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act 
                var stockQuantity = service.GetTotalStockQuantityOfProduct(product);
                //Assert 
                Assert.Equal(30, stockQuantity);
            }
        }
        [Fact]
        public void GetNumberOfProductsOfVendorByItsId()
        {
            //Arrange 
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {                
                dbContext.AddRange(SampleDataHelpers.GetListData());
                dbContext.SaveChanges();                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act 
                var numberOfProducts = service.GetNumberOfProductsByVendorId(1);
                //Assert 
                Assert.Equal(3, numberOfProducts);
            }
        }
        [Fact]
        public async Task InsertProductAsync()
        {
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {                               
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act 
                var sampleProduct = SampleDataHelpers.GetSampleData();
                await service.InsertProductAsync(sampleProduct);
                var product = await service.GetProductByIdAsync(sampleProduct.Id);
                Console.WriteLine(product);
                //Assert                 
                Assert.Equal(sampleProduct,product);
            }
        }
        [Fact]
        public async Task InsertProductsAsync()
        {
            using (var dbContext = new StormyDbContext(SampleDataHelpers.GetDbOptions()))
            {                
                var service = new Core.Services.ProductService(new StormyRepository<StormyProduct>(dbContext));
                //Act 
                var sampleProducts = SampleDataHelpers.GetListData();
                await service.InsertProductsAsync(sampleProducts);
                var products = await service.GetProductsByIdsAsync(sampleProducts
                    .Select(f => f.Id)
                    .ToArray());                
                //Assert                 
                Assert.Equal(sampleProducts, products);
            }
        }
        
    }
}
