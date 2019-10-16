using Moq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Shipping
{
    public class ShipmentServiceTest
    {
        private CorreiosService CreateService()
        {
            var fakeHttpClient = new Mock<HttpClient>();
            fakeHttpClient.Setup(f => f.GetAsync(It.IsAny<string>()))
            .ReturnsAsync(new HttpResponseMessage(System.Net.HttpStatusCode.OK));
            return new CorreiosService(new CalcPrecoPrazoWSSoapClient());
        }

        public ShipmentServiceTest()
        {
        }

        [Fact]
        public async Task CalculateDeliveryPrice_OriginAndReceiverPostalCodes_ShouldReturnPriceAndDeliveryTime()
        {
            //Arrange            
            var service = CreateService();
            //Act
            var result = await service.CalculateDeliveryPriceAndTime(null);
            //Assert
            var containPrice = result.Options.FirstOrDefault(s => s.Price == "R$14.55");
            Assert.NotNull(containPrice);            
        }

        [Fact]
        public async Task CreateShipmentAsync_PassingNotShippedStormyOrder_ShouldReturnShipmentObject()
        {
        }
    }
}
