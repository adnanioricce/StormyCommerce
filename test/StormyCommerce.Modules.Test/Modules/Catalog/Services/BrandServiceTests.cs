using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Services.Catalog;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Services.Catalog
{
    public class BrandServiceTests
    {
        private readonly IBrandService service;
        public BrandServiceTests(IBrandService brandService)
        {
            service = brandService;
        }
        [Fact]
        public async Task GetBrandByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long id = 1;

            // Act
            var result = await service.GetBrandByIdAsync(id);

            // Assert
            Assert.Equal(id,result.Id);
        }

        [Fact]
        public async Task GetAllBrandsAsync_StateUnderTest_ExpectedBehavior()
        {                        
            // Act
            var result = await service.GetAllBrandsAsync();

            // Assert
            Assert.True(result.Count > 0);
        }

        [Fact]
        public async Task AddAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Brand entity = Seeders.BrandSeed().First();
            entity.Id = 0;
            // Act
            await service.AddAsync(entity);

            // Assert
            Assert.True(entity.Id > 0);
        }

        [Fact]
        public async Task DeleteAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long id = 1;
            var brand = await service.GetBrandByIdAsync(1);
            // Act
            await service.DeleteAsync(id);

            // Assert
            Assert.True(brand.IsDeleted);
        }

        [Fact]
        public async Task DeleteAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            Brand entity = await service.GetBrandByIdAsync(1);

            // Act
            await service.DeleteAsync(entity);
            // Assert
            Assert.True(entity.IsDeleted);
        }

        [Fact]
        public async Task UpdateAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Brand entity = await service.GetBrandByIdAsync(1);            
            string brandName = entity.Name;
            entity.Name += "Updated";
            // Act
            await service.UpdateAsync(entity);

            // Assert
            Assert.NotEqual(brandName,entity.Name);
        }
    }
}
