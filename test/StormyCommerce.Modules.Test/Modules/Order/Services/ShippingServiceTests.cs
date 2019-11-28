using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class ShippingServiceTests
    {
        private readonly IShippingService service;        
        public ShippingServiceTests(IShippingService shippingService)
        {
            service = shippingService;
        }
        [Fact]
        public void CalculateShipmentDimensions_StateUnderTest_ExpectedBehavior()
        {
            //TODO:create a seeder that return a predictable data
            // Arrange            
            StormyOrder order = Seeders.StormyOrderSeed().First();
            
            // Act
            var result = service.CalculateShipmentDimensions(order);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreateShipmentAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Shipment shipment = Seeders.ShipmentSeed().First();
            // Act
            await service.CreateShipmentAsync(shipment);            
            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CreateShipmentAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            StormyOrder order = Seeders.StormyOrderSeed().First();

            // Act
            await service.CreateShipmentAsync(order);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetShipmentById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long id = 1;

            // Act
            var result = await service.GetShipmentByIdAsync(id);

            // Assert
            Assert.Equal(id,result.Id);
        }

        [Fact]
        public async Task GetShipmentByOrderIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long orderId = 1;

            // Act
            var result = await service.GetShipmentByOrderIdAsync(orderId);

            // Assert
            Assert.Equal(orderId,result.Order.Id);
        }

        [Fact]
        public async Task GetShipmentByOrderIdAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            Guid uniqueOrderId = default(global::System.Guid);

            // Act
            var result = await service.GetShipmentByOrderIdAsync(uniqueOrderId);

            // Assert
            Assert.Equal(uniqueOrderId,result.Order.OrderUniqueKey);
        }

        [Fact]
        public async Task CalculateDeliveryCost_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
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
            Shipment request = null;

            // Act
            var result = await service.CalculateDeliveryCost(request,ServiceCode.Sedex);

            // Assert
            Assert.True(false);
        }
    }
}
