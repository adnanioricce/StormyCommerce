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
        //private readonly 
        public BasicTests(CustomWebApplicationFactory factory)
        {
            _factory = factory;
            _httpClient = factory.CreateClient();
        }
        [Theory]
        [InlineData("/catalog/product/1")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            //Arrange
            //var client = _factory.s
            var response = await _httpClient.GetAsync(url);
            //Act

            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal("application/json; charset=utf-8",response.Content.Headers.ContentType.ToString());
        }
    }
}
