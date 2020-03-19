
using SimplCommerce.Module.Correios.Models;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Models.Requests;
using SimplCommerce.Module.Shipments.Services;
using System.Threading.Tasks;
using Xunit;

namespace SimplCommerce.Module.Correios.Tests.Services
{
    public class CorreiosFreightCalculatorTests
    {
        private readonly IFreightCalculator _freightCalculator;
        public CorreiosFreightCalculatorTests(IFreightCalculator freightCalculator)
        {
            _freightCalculator = freightCalculator;
        }                

        [Fact]
        public async Task CalculateFreightForPackage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            CalculatePackageFreightRequest request = new CalculatePackageFreightRequest { 
                DestinationZipCode = "19190970",
                ShippingMethod = ServiceCode.Sedex,
                CartId = 1
            };

            // Act
            var result = await _freightCalculator.CalculateFreightForPackage(request);

            // Assert
            Assert.True(result.Options.Count >= 1);            
        }
    }
}
