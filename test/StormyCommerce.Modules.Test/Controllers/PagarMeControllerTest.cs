using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class PagarMeControllerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;
        public PagarMeControllerTest(CustomWebApplicationFactory factory, ITestOutputHelper output)
        {
            _client = factory.WithWebHostBuilder(builder =>
            {
                builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");
            }).CreateClient();
            _output = output;
        }
        [Fact]
        public async Task CheckoutOrder_SendTransactionVmWithOrderId_ReturnStatusCode200()
        {
            //Arrange
            await _client.GetAsync("/api/seed");
        }
    }
}
