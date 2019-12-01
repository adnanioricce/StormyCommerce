using System.Threading.Tasks;
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Core.Interfaces.Domain.Shipping
{
    //?Should I do this here or on the client?
    public interface IShippingService
    {
        Task<StormyShipment> PrepareShipment(PrepareShipmentRequest request);
        Task<Result> CreateShipmentAsync(StormyShipment shipment);
    }
}
