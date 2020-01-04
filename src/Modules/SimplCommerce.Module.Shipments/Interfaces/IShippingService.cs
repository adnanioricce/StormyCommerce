using System.Threading.Tasks;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Requests;
using StormyCommerce.Core.Models;

namespace SimplCommerce.Module.Shipments.Interfaces
{
    //?Should I do this here or on the client?
    public interface IShippingService
    {
        Task<Shipment> PrepareShipment(PrepareShipmentRequest request);
        Task<Result> CreateShipmentAsync(Shipment shipment);
    }
}
