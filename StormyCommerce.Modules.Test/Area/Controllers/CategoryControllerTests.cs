using AutoMapper;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Area.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Test.Area.Controllers
{
    public class CategoryControllerTests
    {
        [Fact]
        public async Task GetAll_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = new CategoryController(null,null);

            // Act
            var result = await categoryController.GetAll();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCategoryById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = new CategoryController(null, null);
            long id = 0;

            // Act
            var result = await categoryController.GetCategoryById(
                id);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CreateCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = new CategoryController(null, null);
            CategoryDto categoryDto = null;

            // Act
            var result = await categoryController.CreateCategory(
                categoryDto);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task EditCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var categoryController = new CategoryController(null,null);
            CategoryDto categoryDto = null;

            // Act
            var result = await categoryController.EditCategory(
                categoryDto);

            // Assert
            Assert.True(false);
        }
    }
}
