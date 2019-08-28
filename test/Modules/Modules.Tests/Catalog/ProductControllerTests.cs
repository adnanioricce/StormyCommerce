﻿using AutoMapper;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SimplCommerce.Module.SampleData;
using StormyCommerce.Api.Framework.Extensions;
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
        private readonly ProductController _productController;        
        public ProductControllerTests()
        {
            _productController = CreateController();
        }
        private ProductController CreateController()
        {
            var dbContext = DbContextHelper.GetDbContext();                                    
            var repository = new StormyRepository<StormyProduct>(dbContext);

            var productService = new ProductService(repository);

            var profile = new CatalogProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = configuration.CreateMapper();
            return new ProductController(productService, mapper);
        }                
        [Fact]
        public async Task GetProductOverviewAsync_IdEqual1_ReturnMinifiedVersionOfProductDto()
        {
            // Arrange                                
            long id = 1;

            // Act
            var result = await _productController.GetProductOverviewAsync(id);

            // Assert
            Assert.Equal(1,result.Value.Id);
        }

        [Fact]
        public async Task GetAllProducts_StartIndexEqual1AndEndIndexEqual15_ReturnEntitiesBetweenThesesValues()
        {
            // Arrange                        
            long startIndex = 1;
            long endIndex = 15;

            // Act
            var result = await _productController.GetAllProducts(startIndex,endIndex);

            // Assert            
            Assert.Equal(15,result.Value.Count);            

        }

        [Fact]
        public async Task GetAllProductsOnHomepage_LimitEqual15_ReturnProductsWhileRankingIsLessThanLimit()
        {
            // Arrange            
            int limit = 15;

            // Act
            var result = (await _productController.GetAllProductsOnHomepage(limit));

            // Assert          
            Assert.NotNull(result);
            Assert.Equal(15,result.Value.Count);
        }

        [Fact]
        public async Task GetProductById_GivenIdEqual1_ReturnEntityWithGivenId()
        {
            // Arrange            
            long id = 1;

            // Act
            var result = (await _productController.GetProductById(id));

            //Assert                         
            Assert.Equal(1,result.Value.Id);                        
        }

        [Fact]
        public async Task CreateProduct_GivenModelIsValidDto_CreateNewEntryOnDatabase()
        {
            // Arrange            
            var product = Seeders.StormyProductSeed(1).FirstOrDefault();

            var model = new ProductDto(product,0);            
            // Act
            var result = await _productController.CreateProduct(model);           
            // Assert            
            var objResult = Assert.IsType<OkResult>(result);
            Assert.Equal(200, objResult.StatusCode);
        }
    }
}
