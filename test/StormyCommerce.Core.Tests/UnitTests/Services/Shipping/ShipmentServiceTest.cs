using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Shipping
{
    public class ShipmentServiceTest
    {
        public ShipmentServiceTest()
        {

        }
        [Fact]
        public async Task CalculateDeliveryPrice_OriginAndReceiverPostalCodes_ShouldReturnPriceAndDeliveryTime()
        {
            //Arrange
            var calculateShippingModel = new CalculateShipping{

            };
            
            //Act
            // var result = 
        }
    }
}
