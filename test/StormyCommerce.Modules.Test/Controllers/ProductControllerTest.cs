using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using SimplCommerce.WebHost;
using Xunit;

namespace StormyCommerce.Modules.Test.Controllers
{
    public class ProductControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;        
        public ProductControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }
        //TODO:What Errors codes should I return?
        //TODO:How to pass objects like arguments
        // [Theory]
        // [InlineData("/api/product/CreateProduct")]
        // public async Task Post_CreateProduct_InvalidInput_ShouldCorrespondentReturnErrorCode(string url)
        // {
        //     //Arrange 
        //     //Act
        //     //Assert
        // }
    }
}