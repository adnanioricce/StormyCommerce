using AutoMapper;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Core.Shipment;
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
            DeliveryCalculationRequest model = new DeliveryCalculationRequest {
                DestinationPostalCode = "08621030",
                Diameter = 0,
                FormatCode = FormatCode.CaixaOuPacote,
                Height = 2,
                Width = 16,
                Length = 11,
                ShippingMethod = ShippingMethod.Sedex,
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
