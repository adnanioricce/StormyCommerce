using Xunit;
using TestHelperLibrary.Mocks;
using System.Net.Http;
using StormyCommerce.Modules.IntegrationTest;
using Microsoft.AspNetCore.TestHost;

namespace StormyCommerce.Modules.Test.Controllers
{
    public class ShippingControllerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        public ShippingControllerTest(CustomWebApplicationFactory factory)
        {
            _client = factory.WithWebHostBuilder(builder => 
            {
                builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");
            }).CreateClient();                        
        }
        [Fact]
        public void CalculateDeliveryCostAsync_WhenReceivesCalculateDeliveryVm_ReturnAllShippingOption()
        {
            //Given
            // var model = new CalculateDeliveryCost{
                
            // };
            //When
        
            //Then
        }
    }
}