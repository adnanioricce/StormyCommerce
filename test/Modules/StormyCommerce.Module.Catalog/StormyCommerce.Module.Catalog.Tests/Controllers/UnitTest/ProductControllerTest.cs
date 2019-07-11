using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Area.Controllers;
using StormyCommerce.Module.Catalog.Dtos;
using System.Threading.Tasks;
using Xunit;
namespace StormyCommerce.Module.Catalog.Tests.Controllers.UnitTest
{
    public class ProductControllerTest 
    {
        private readonly ProductController _productController;
        public ProductControllerTest(ProductController productController)
        {
            _productController = productController;
        }
        [Fact]
        public async Task ShouldGetProductOverviewAsync()
        {
            //Arrange
            //Act
            //Assert
            Assert.NotNull(null);
        }
        [Theory]
        [InlineData(0,5)]
        [InlineData(5, 10)]
        [InlineData(-1,2)]
        [InlineData(0x000004,-2)]
        public async Task ShouldGetAllProducts(long startIndex, long endIndex)
        {
            //Arrange
            //Act
            //Assert
            Assert.NotNull(null);
        }
        [Fact]
        public async Task GetAllProductsOnHomepage()
        {
            //Arrange
            //Act
            //Assert
            Assert.NotNull(null);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(-2)]
        [InlineData(100000000)]
        [InlineData(0x00005)]
        [InlineData(0.1)]
        [InlineData(0)]
        [InlineData(1.499999999999999999)]
        public async Task GetProductById(long id)
        {
            //Arrange
            //Act
            //Assert
            Assert.NotNull(null);
        }
        [Theory]
        [InlineData(null)]        
        public async Task CreateProduct(ProductDto productDto)
        {
            //Arrange
            //Act
            //Assert
            Assert.NotNull(productDto);
        }
    }
}
