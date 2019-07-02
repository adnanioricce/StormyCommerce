using Xunit;
using SimplCommerce.Module.Catalog.Services;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using TestHelperLibrary;
namespace StormyCommerce.Module.Catalog.Tests.Controllers.FunctionalTests
{
    public class ProductControllerTest : IClassFixture<CustomWebApplicationFactory<FakeStartup>>
    {
        private readonly CustomWebApplicationFactory<FakeStartup> _factory;
        private readonly IProductService _productService;
        private readonly HttpClient _httpClient;
        public ProductControllerTest(CustomWebApplicationFactory<FakeStartup> factory,IProductService productService)
        {
            _factory = factory;
            var clientOptions = new WebApplicationFactoryClientOptions();
            clientOptions.BaseAddress = new System.Uri("http://localhost/api/");                        
            _httpClient = _factory.CreateClient(clientOptions);
            _productService = productService;
        }
        [Theory]
        [InlineData("product")]
        public async Task Get_EndpointReturnSuccess_And_CorrectContentType(string url)
        {
            //Arrange 
            var client = _factory.CreateClient();
            //Act 
            var response = await client.GetAsync(url);
            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("text/json; charset=utf-8",response.Content.Headers.ContentType.ToString());
        }        
    }
}
