using AutoMapper;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Module.Orders.Area.Controllers;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Area.Models.Shipping;
using StormyCommerce.Module.Orders.Services;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class ShippingControllerTests
    {
        private readonly ShippingController _controller;
        public ShippingControllerTests(CorreiosService correiosService,IShippingService shippingService,IMapper mapper)
        {
            _controller = new ShippingController(correiosService,shippingService,mapper);
        }
        [Fact]
        public async Task CalculateDeliveryCost_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            //TODO
            DeliveryCalculationRequest model = null;

            // Act
            var result = await _controller.CalculateDeliveryCost(model);

            // Assert
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async Task CalculateDeliveryCost_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            DeliveryCalculationForOrderRequest model = null;

            // Act
            var result = await _controller.CalculateDeliveryCost(model);

            // Assert
            Assert.NotNull(result.Value);
        }
    }
}
