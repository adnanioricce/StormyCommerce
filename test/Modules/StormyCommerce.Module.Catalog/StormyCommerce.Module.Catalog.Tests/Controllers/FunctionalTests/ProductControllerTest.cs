using Xunit;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using TestHelperLibrary;
using SimplCommerce.WebHost;

namespace StormyCommerce.Module.Catalog.Tests.Controllers.FunctionalTests
{
    public class ProductControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<FakeStartup> _factory;        
        private readonly HttpClient _httpClient;
        public ProductControllerTest(CustomWebApplicationFactory<FakeStartup> factory)
        {
            _factory = factory;
            //_factory.
            var clientOptions = new WebApplicationFactoryClientOptions();
            clientOptions.BaseAddress = new System.Uri("http://localhost/api/");                        
            _httpClient = _factory.CreateClient(clientOptions);         
        }
        [Theory]
        [InlineData("product")]
        public async Task Get_EndpointReturnSuccess_And_CorrectContentType(string url)
        {
            //Arrange 
            //var client = _factory.CreateClient();
            //Act 
            var response = await _httpClient.GetAsync(url);
            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8",response.Content.Headers.ContentType.ToString());
        }        
    }
}
