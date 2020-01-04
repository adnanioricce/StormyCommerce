using AutoMapper;
using SimplCommerce.Module.Shipments.Interfaces;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Models.Request;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Module.Orders.Area.Controllers;
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
            DeliveryCalculationRequest model = new DeliveryCalculationRequest {
                DestinationPostalCode = "08621030",
                Diameter = 0,
                FormatCode = FormatCode.CaixaOuPacote,
                Height = 2,
                Width = 16,
                Length = 11,
                ShipmentMethod = ShippingMethod.Sedex,
                Weight = 0.3m,
                WarningOfReceiving = "S",
                ValorDeclarado = 100,
                MaoPropria = "N"
            };

            // Act
            var result = await _controller.CalculateDeliveryCost(model);

            // Assert
            Assert.NotNull(result.Value);
        }

        
    }
}
