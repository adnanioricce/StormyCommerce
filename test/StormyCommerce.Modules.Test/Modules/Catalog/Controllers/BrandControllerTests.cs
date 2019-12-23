using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Module.Catalog.Controllers;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class BrandControllerTests
    {
        private readonly BrandController _controller;
        public BrandControllerTests(IBrandService brandService)
        {
            _controller = new BrandController(brandService);
        }
        [Fact]
        public async Task CreateBrand_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Brand brand = Seeders.BrandSeed().First();
            brand.Id = 0;
            // Act
            var result = (await _controller.CreateBrand(brand)) as OkObjectResult;

            // Assert
            Assert.Equal(200,(int)result.StatusCode);
        }

        [Fact]
        public async Task GetBrandById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            int id = 1;

            // Act
            var result = await _controller.GetBrandById(
                id);

            // Assert
            Assert.Equal(id,result.Id);
        }

        [Fact]
        public async Task GetAllBrand_StateUnderTest_ExpectedBehavior()
        {                        
            // Act
            var result = await _controller.GetAllBrand();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }
    }
}
