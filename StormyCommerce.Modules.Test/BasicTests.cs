using Microsoft.AspNetCore.Mvc.Testing;
using SimplCommerce.WebHost;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest
{
    public class BasicTests : IClassFixture<TestFixture<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _httpClient;
        public BasicTests(TestFixture<Startup> factory)
        {
            _factory = factory;
            _httpClient = _factory.CreateClient();
        }
        [Theory]
        [InlineData("http://localhost:49209/catalog/product/1")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            //Arrange
            //Act
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal("application/json; charset=utf-8",response.Content.Headers.ContentType.ToString());
        }
    }
}
