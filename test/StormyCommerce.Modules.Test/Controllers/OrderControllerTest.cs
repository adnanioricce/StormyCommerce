using Microsoft.AspNetCore.TestHost;
using StormyCommerce.Api.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class OrderControllerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;
        public OrderControllerTest(CustomWebApplicationFactory factory, ITestOutputHelper output)
        {
            _client = factory.WithWebHostBuilder(builder =>
            {
                builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");
            }).CreateClient();
            _output = output;
        }        
        [Fact]
        public async Task CreateOrderAsync_WhenSendValidOrder_Return200StatusCode()
        {
            //Arrange
            var order = Seeders.StormyOrderSeed().First();
            order.Customer = Seeders.StormyCustomerSeed().First();
            // order.Items = Seeders.OrderItemSeed();
            // order.Payment = Seeders.PaymentSeed();
            order.Shipment = Seeders.ShipmentSeed().First();                        
            order.Status = Core.Entities.Order.OrderStatus.New;            
            //Act
            var response = await _client.PostAsJsonAsync("/api/order/create",order);
            //Assert
            Assert.Equal(200,(int)response.StatusCode);            
        }
        // public async Task GetOrder
        
    }
}
