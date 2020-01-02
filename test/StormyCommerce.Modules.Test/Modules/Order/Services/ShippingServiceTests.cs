using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Shipping;

using StormyCommerce.Core.Interfaces.Domain.Shipping;
 
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Module.Orders.Interfaces;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class ShippingServiceTests
    {
        private readonly IShippingService service;
        private readonly IOrderService _orderService;        
        public ShippingServiceTests(IShippingService shippingService,IOrderService orderService)
        {
            service = shippingService;
            _orderService = orderService;
        }
        [Fact]
        public async Task PrepareOrderForShipment_ReceivesPrepareShipmentRequestObject_ReturnPrepareShipmentResponse()
        {
            //Arrange
            var order = await _orderService.CreateOrderAsync(null);            
            var request = new PrepareShipmentRequest
            {
                TotalPrice = 100,
                DestinationPostalCode = "08621030",
                ShippingMethod = ShippingMethod.Sedex,
                Order = order.Value                
            };
            //Act 
            var response = await service.PrepareShipment(request);
            //Assert
            Assert.Equal(16, response.TotalWidth);
            Assert.Equal(11, response.TotalLength);
            Assert.Equal(2, response.TotalHeight);
            Assert.Equal(116, response.TotalArea);
            Assert.Equal(26.32m, response.DeliveryCost);
            Assert.Equal(ShippingStatus.NotShippedYet, response.Status);            
        }
    }
}
