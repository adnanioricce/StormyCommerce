using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Services.Shipping;
using System;
using Xunit;

namespace StormyCommerce.Modules.Tests.Services.Shipping
{
    public class ShippingBuilderTests
    {
        [Fact]
        public void CalculateShippingMeasures_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var shippingBuilder = new ShippingBuilder();
            OrderDto order = null;

            // Act
            var result = shippingBuilder.CalculateShippingMeasures(new Core.Models.Shipment.CalculateShippingMeasuresModel(order.Items));

            // Assert
            Assert.True(false);
        }
    }
}
