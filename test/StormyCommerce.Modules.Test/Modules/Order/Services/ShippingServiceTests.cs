using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Module.Orders.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Order
{
    public class ShippingServiceTests
    {
        [Fact]
        public void CalculateShipmentDimensions_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            StormyOrder order = null;

            // Act
            var result = service.CalculateShipmentDimensions(
                order);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CreateShipmentAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            Shipment shipment = null;

            // Act
            await service.CreateShipmentAsync(
                shipment);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CreateShipmentAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            StormyOrder order = null;

            // Act
            await service.CreateShipmentAsync(
                order);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetShipmentById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            long id = 0;

            // Act
            var result = await service.GetShipmentById(
                id);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetShipmentByOrderIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            long orderId = 0;

            // Act
            var result = await service.GetShipmentByOrderIdAsync(
                orderId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetShipmentByOrderIdAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            Guid uniqueOrderId = default(global::System.Guid);

            // Act
            var result = await service.GetShipmentByOrderIdAsync(
                uniqueOrderId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CalculateDeliveryCost_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            Shipment shipment = null;
            string serviceCode = null;

            // Act
            var result = await service.CalculateDeliveryCost(
                shipment,
                serviceCode);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CalculateDeliveryCost_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var service = new ShippingService(TODO, TODO, TODO);
            DeliveryCalculationRequest request = null;

            // Act
            var result = await service.CalculateDeliveryCost(
                request);

            // Assert
            Assert.True(false);
        }
    }
}
