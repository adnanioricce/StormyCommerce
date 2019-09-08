using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Models.Dtos.GatewayRequests;

namespace StormyCommerce.Core.Interfaces.Domain.Shipping
{
    //?Should I do this here or on the client?
    public interface IShippingService
    {
        Task CreateShipmentAsync(Shipment shipment);
        Task CreateShipmentAsync(StormyOrder order);

        //TODO:This is more complicated than seem:You need of the postal Code, and info about the object to ship
        //ex:postal code is 99999999 and has 24kg, that will give diferent shipOptions
        // Task<List<Shipment>> GetShippmentOptionsAsync( shipment);        
        Task<Shipment> CalculateDeliveryPrice(ShipmentCalculationDto calculateShippingModel);         
        // Task<Ship>
    }
}
