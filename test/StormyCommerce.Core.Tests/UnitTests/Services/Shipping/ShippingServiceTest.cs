using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Services;
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
        public async Task CreateShipmentAsync_ReceivesShipmentEntity_CreateNewEntryOnDatabase()
        {
            //Arrange 
            var shipment = Seeders.ShipmentSeed().First();
            var service = new ShippingService(RepositoryHelper.GetRepository<Shipment>(),RepositoryHelper.GetRepository<StormyOrder>(),new CorreiosService(new CalcPrecoPrazoWSSoapClient()));
            //Act 
            await service.CreateShipmentAsync(shipment);
            //Assert            
            var createdShipment = await service.GetShipmentById(shipment.Id);
            Assert.Equal(shipment.Id,createdShipment.Id);            
        }
           
    }
}
