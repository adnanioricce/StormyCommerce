using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Area.Controllers;
using TestHelperLibrary.Mocks;
using System;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using SimplCommerce.Module.SampleData.Extensions;

namespace Modules.Test
{
    public class CategoryControllerTests
    {        
        private CategoryController CreateController()
        {
            return new CategoryController(ServiceTestFactory.GetCategoryService(),ServiceTestFactory.GetFakeMapper());
        }
        [Fact]
        public async Task GetAll_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = CreateController();

            // Act
            var result = await categoryController.GetAll();

            // Assert
            //TODO: Change to check against a defined length
            Assert.True(result.Value.Count() > 0);
        }

        [Fact]
        public async Task GetCategoryById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = CreateController();
            long id = 1;

            // Act
            var result = await categoryController.GetCategoryById(id);

            // Assert
            Assert.Equal(id,result.Value.Id);
        }

        [Fact]
        public async Task CreateCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = CreateController();
            CategoryDto categoryDto = new CategoryDto(Seeders.CategorySeed(1).FirstOrDefault());

            // Act
            var result = await categoryController.CreateCategory(categoryDto);

            // Assert
            //TODO: Actually, you need to return something that's verifable
            // Assert.Equal(categoryDto.Name,result.);
            Assert.True(false)
        }

        [Fact]
        public async Task EditCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = CreateController();
            CategoryDto categoryDto = new CategoryDto(Seeders.CategorySeed(1).FirstOrDefault());
            var service = ServiceTestFactory.GetCategoryService();
            // Act
            var result = await categoryController.EditCategory(categoryDto);

            // Assert
            // Assert.NotEqual()
            Assert.True(false);
        }
    }
}
