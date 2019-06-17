using Newtonsoft.Json;
using SimplCommerce.WebHost;
using StormyCommerce.Module.Catalog.Tests.Infraestructure;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Module.Catalog.Tests.Product
{
    public class Create : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        public Create(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }
        [Fact]
        public async Task Return_ProductId_On_Response_Of_CreateProductCommand()
        {
            var command = new CreateProductCommand
            {
                ProductName = "Blusa Nike Vermelha",
                VendorId = 1,
                CategoryId = 1,
                UnitPrice = 99.90,                
            };
            var content = Utils.Utilities.GetRequestContent(command);
            var response = await _client.PostAsync($"/api/products/create", content);
            response.EnsureSuccessStatusCode();
            var productId = await Utils.Utilities.GetResponseContent<int>(response);
            Assert.NotEqual(0, productId);
        }
    }
}
