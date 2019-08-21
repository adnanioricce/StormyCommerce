using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SimplCommerce.Module.SampleData;
using SimplCommerce.Module.SampleData.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Infraestructure.Helpers;
using StormyCommerce.Module.Catalog.Area.Controllers;
using StormyCommerce.Module.Catalog.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Mocks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Modules.Test.Area.Controllers
{
    public class ProductControllerTests
    {
        //! I think this will fail, define some logic to the mock        
        private ProductController CreateController()
        {
            var dbContext = DbContextHelper.GetDbContext();
            dbContext.AddRange(Seeders.StormyProductSeed(50));
            dbContext.SaveChanges();
            var repository = new StormyRepository<StormyProduct>(dbContext);
            var productService = new ProductService(repository);
            var profile = new CatalogProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = configuration.CreateMapper();
            return new ProductController(productService, mapper);
        }
        //! You are violating DRY again
        //private ProductController CreateControllerForProductOverview()
        //{
        //    var dbContext = DbContextHelper.GetDbContext();
        //    dbContext.AddRange(Seeders.StormyProductSeed(50));
        //    dbContext.SaveChanges();
        //    var repository = new StormyRepository<StormyProduct>(dbContext);
        //    var productService = new ProductService(repository);
        //    var profile = new CatalogProfile();
        //    var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
        //    var mapper = new Mapper(configuration);
        //    return new ProductController(productService, mapper);
        //}
        [Fact]
        public async Task GetProductOverviewAsync_IdEqual1_ReturnMinifiedVersionOfProductDto()
        {
            // Arrange                    
            var productController = CreateController();
            long id = 8;

            // Act
            var result = await productController.GetProductOverviewAsync(id);

            // Assert
            Assert.Equal(8,result.Value.Id);
        }

        [Fact]
        public async Task GetAllProducts_StartIndexEqual1AndEndIndexEqual15_ReturnEntitiesBetweenThesesValues()
        {
            // Arrange            
            var productController = CreateController();
            long startIndex = 1;
            long endIndex = 15;

            // Act
            var result = await productController.GetAllProducts(startIndex,endIndex);

            // Assert
            Assert.Equal(15,result.Value.Count);
        }

        [Fact]
        public async Task GetAllProductsOnHomepage_LimitEqual15_ReturnProductsWhileRankingIsLessThanLimit()
        {
            // Arrange
            var productController = CreateController();
            int limit = 15;

            // Act
            var result = (await productController.GetAllProductsOnHomepage(limit));

            // Assert            
            Assert.Equal(limit,result.Value.Count);
        }

        [Fact]
        public async Task GetProductById_GivenIdEqual1_ReturnEntityWithGivenId()
        {
            // Arrange
            var productController = CreateController();
            long id = 1;

            // Act
            var result = await productController.GetProductById(id);
            //var returnResult = Assert.IsType<OkObjectResult>(result);
            //var valueResult = Assert.IsType<ProductDto>(result);
            // Assert
            //Assert.Equal(200, returnResult.StatusCode);
            //Assert.NotNull(valueResult);
            Assert.Equal(id, result.Value.Id);
        }

        [Fact]
        public async Task CreateProduct_GivenModelIsValidDto_CreateNewEntryOnDatabase()
        {
            // Arrange
            var productController = CreateController();
            var product = Seeders.StormyProductSeed(1).FirstOrDefault();

            var model = new ProductDto(product);            
            // Act
            var result = await productController.CreateProduct(model);           
            // Assert            
            var objResult = Assert.IsType<OkResult>(result);
            Assert.Equal(200, objResult.StatusCode);
        }
    }
}
