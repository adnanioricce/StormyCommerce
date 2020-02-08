using SimplCommerce.Module.Core.Models;
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
    public class ProductServiceTests : IClassFixture<TestBase>
    {
        private readonly IStormyProductService service;
        private readonly IRepository<Product> _productRepository;        
        public ProductServiceTests(IStormyProductService productService,IRepository<Product> productRepository,IRepository<Vendor> vendorRepository)
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
            Product product = ProductSeeder.InsertProductSeed();                 
            int vendorId = 1;
            product.VendorId = vendorId;            

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
            _productRepository.SaveChanges();
            // Act
            var result = await service.GetProductByIdAsync(product.Id);

            // Assert
            Assert.Equal(product.Id, result.Id);
        }

        [Fact]
        public async Task SearchProductsBySearchPattern_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                 
            string searchPattern = "test";

            // Act
            var result = await service.SearchProductsBySearchPattern(searchPattern);

            // Assert
            Assert.True(result.All(prop => prop.Name.Contains(searchPattern.ToLower())));
        }

        [Fact]
        public async Task GetProductBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Product product = ProductSeeder.InsertProductSeed(); 
            _productRepository.Add(product);                        
            _productRepository.SaveChanges();
            // Act
            var result = await service.GetProductBySkuAsync(product.Sku);

            // Assert
            Assert.Equal(product.Sku,result.Sku);
        }

        [Fact]
        public async Task GetProductsByIdsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var productIds = new long[] { 1L,2L };            

            // Act
            var result = await service.GetProductsByIdsAsync(productIds);

            // Assert
            Assert.Equal(2,result.Count);
        }

        [Fact]
        public async Task GetProductByNameAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange           
            Product product = ProductSeeder.InsertProductSeed(); 
            _productRepository.Add(product);            
            _productRepository.SaveChanges();
            // Act
            var result = await service.GetProductByNameAsync(product.Name);

            // Assert
            Assert.Equal(product.Name,result.Name);
        }

        [Fact]
        public async Task GetProductsBySkuAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var skuArray = _productRepository.Query().Select(p => p.Sku).Take(3).ToList();            

            // Act
            var result = await service.GetProductsBySkuAsync(skuArray);

            // Assert
            Assert.NotEqual(skuArray,result.Select(p => p.Sku));
        }

        [Fact]
        public void GetTotalStockQuantity_StateUnderTest_ExpectedBehavior()
        {         
            //Arrange 
            Product product = ProductSeeder.InsertProductSeed();
            _productRepository.Add(product);
            _productRepository.SaveChanges();   
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
            var product = _productRepository.Query()
                .Where(p => p.Id == _productRepository.Query().Count())
                .FirstOrDefault();                                       
            long id = product.Id;
            // Act
            await service.DeleteProductAsync(product);

            // Assert
            var result = await _productRepository.GetByIdAsync(id);
            Assert.Null(result);
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
            const int productId = 1;
            Product product = await _productRepository.GetByIdAsync(productId);
            var oldName = product.Name;
            product.Name += " Updated";
            // Act
            await service.UpdateProductAsync(product);

            // Assert
            Assert.NotEqual(oldName,product.Name);
        }

        [Fact]
        public async Task UpdateProductsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            IList<Product> products = new List<Product>{
                await _productRepository.GetByIdAsync(1),
                await _productRepository.GetByIdAsync(2)
            };            
            products.ToList().ForEach(p => p.Name += " Updated");
            // Act
            await service.UpdateProductsAsync(products);
            var actualProducts = await service.GetProductsByIdsAsync(products.Select(p => p.Id));
            // Assert
            Assert.True(actualProducts.ToList().Select(p => p.Name).All(p => p.Contains("Updated")));
        }        
    }
}
