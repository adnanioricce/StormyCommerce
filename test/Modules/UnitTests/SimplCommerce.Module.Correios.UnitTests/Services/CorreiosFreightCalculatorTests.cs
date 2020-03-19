
using SimplCommerce.Module.Correios.Models;
using SimplCommerce.Module.Correios.Services;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Models.Requests;
using SimplCommerce.Module.Shipments.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Tests;
using System.Threading.Tasks;
using Xunit;

namespace SimplCommerce.Module.Correios.Tests.Services
{
    public class CorreiosFreightCalculatorTests
    {        
        public CorreiosFreightCalculatorTests()
        {
            
        }                
        private CorreiosService CreateMockCorreiosService()
        {
            var mockService = new Mock<CorreiosService>();
            
        }
        [Fact]
        public async Task CalculateFreightForPackage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                  
            
            var repo = new FakeRepository<Cart>();
            
            var _freightCalculator = new CorreiosFreightCalculator(,repo,null,new PackageBuilder());
            var request = new CalculatePackageFreightRequest { 
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
