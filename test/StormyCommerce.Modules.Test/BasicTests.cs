using Microsoft.AspNetCore.Mvc.Testing;
using SimplCommerce.WebHost;
using System.Net.Http;
using System.Threading.Tasks;
using TestHelperLibrary;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest
{
    public class BasicTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _httpClient;        
        public BasicTests(CustomWebApplicationFactory factory)
        {
            _factory = factory;
            _httpClient = factory.CreateClient();
        }
        [Theory]
        [InlineData("/api/Product/GetProductById/1")]
        [InlineData("/api/Product/GetProductOverviewAsync/1")]
        [InlineData("/api/Product/GetAllProducts/")]
        [InlineData("/api/Product/GetNumberOfProductsInCategory/")]
        [InlineData("/api/Category/GetAll/list")]
        [InlineData("/api/Category/GetCategoryById/1")]  
        public async Task GetCategories_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            //Arrange            
            var response = await _httpClient.GetAsync(url);
            //Act

            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal("application/json; charset=utf-8",response.Content.Headers.ContentType.ToString());
        }        
    }
}
