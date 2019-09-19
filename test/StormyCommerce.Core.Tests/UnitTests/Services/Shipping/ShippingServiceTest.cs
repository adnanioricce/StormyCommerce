using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Module.PagarMe.Services;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Shipping
{
    public class ShippingServiceTest
    {
        [Fact]
        public async Task GetShipmentOptionsAsync_ReceivesAddressVm_ReturnShipmentOptions()
        {
            //Arrange
            // var addressDto = new AddressDto
            //Act
            // var shipmentOptions = _service.GetShipmentOptions(addressVm)
            //Assert
            //Assert.Equal(5,addressDto);
        }
        [Fact]
        public async Task CreateShipmentAsync_ReceivesShipmentEntity_CreateNewEntryOnDatabase()
        {
            //Arrange 
            var shipment = Seeders.ShipmentSeed().First();
            var service = new ShippingService(RepositoryHelper.GetRepository<Shipment>(),RepositoryHelper.GetRepository<StormyOrder>());
            //Act 
            await service.CreateShipmentAsync(shipment);
            //Assert
            //var createdShipment = 
            
        }
    }
}
