using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Area.Controllers;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Module.Catalog.Tests.Controllers.UnitTest
{
    public class CategoryControllerTest
    {
        private readonly CategoryController _categoryController;
        public CategoryControllerTest(CategoryController categoryController)
        {
            _categoryController = categoryController;
        }
        [Fact]
        public async Task ShouldGetAllCategoriesDatabase()
        {
            //Arrange             
            //Act 
            var response = await _categoryController.GetAll();           
            //Assert
            Assert.Equal(0,response.Value.Count);
        }
        [Theory]
        [InlineData(null)]
        [InlineData(1)]
        public async Task ShouldGetCategoryById_OtherwiseReturnNotFound(long id)
        {
            Assert.NotNull(null);
        }
        [Theory]
        [InlineData(null)]
        public async Task ShouldCreateCategoryByValidRequest_OtherwiseShouldStopAndReturnError(CategoryDto categoryDto)
        {
            Assert.NotNull(categoryDto);
        }
        [Theory]
        [InlineData(null)]
        public async Task EditCategory(CategoryDto categoryDto)
        {
            Assert.NotNull(categoryDto);
        }
    }
}
