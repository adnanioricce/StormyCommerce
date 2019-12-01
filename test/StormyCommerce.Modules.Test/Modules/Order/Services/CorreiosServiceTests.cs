using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class CorreiosServiceTests
    {
        private readonly CorreiosService service;
        public CorreiosServiceTests(CorreiosService correiosService)
        {
            service = correiosService;
        }
        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var model = new CalcPrecoPrazoModel
            {
                
            };

            // Act
            var result = await service.CalculateDeliveryPriceAndTime(model);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DefaultDeliveryCalculation_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var shipment = new StormyShipment { 
                TotalHeight = 2,
                TotalWidth = 11,
                TotalLength = 16,
                TotalArea = 2 * 11 * 16,
                TotalWeight = 1,
                Order = new Core.Entities.StormyOrder
                {
                    TotalPrice = 100
                },
                DestinationAddress = new Core.Entities.Customer.CustomerAddress { 
                    PostalCode = "08621030"
                }                
                
            };

            // Act
            var result = await service.DefaultDeliveryCalculation(shipment);

            // Assert
            Assert.True(result.Options.Count == 1);
        }

        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            var request = new DeliveryCalculationRequest {
                Height = 2,
                Width = 16,
                Length = 11,
                Weight = 1,
                Diameter = 0,
                WarningOfReceiving = "N",
                FormatCode = Core.Shipment.FormatCode.CaixaOuPacote,
                MaoPropria = "N",
                ShippingMethod = ServiceCode.Sedex,
                ValorDeclarado = 1.61m,
                DestinationPostalCode = "08621030",                
                
            };

            // Act
            var result = await service.CalculateDeliveryPriceAndTime(request);

            // Assert
            Assert.True(result.Options.Exists(o => string.Equals(o.Service,"Sedex",StringComparison.OrdinalIgnoreCase) && o.Price == 24.11m));
            Assert.True(result.Options.Exists(o => string.Equals(o.Service, "PAC", StringComparison.OrdinalIgnoreCase) && o.Price == 22.61m));
            Assert.True(result.Options.Exists(o => string.Equals(o.Service, "SEDEX10", StringComparison.OrdinalIgnoreCase) && o.Price == 34.51m));

        }
    }
}
