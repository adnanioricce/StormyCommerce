using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Dtos.GatewayRequests;
using System.Threading.Tasks;
using System;
namespace StormyCommerce.Core.Interfaces.Domain.Shipping
{
    //?Should I do this here or on the client?
    public interface IShippingService
    {
        Task CreateShipmentAsync(Entities.Shipment shipment);
        Task CreateShipmentAsync(StormyOrder order);
        Entities.Shipment CalculateShipmentDimensions(StormyOrder order);     
        Task<Entities.Shipment> CalculateDeliveryCost(Entities.Shipment request,string serviceCode);   
        Task<Entities.Shipment> GetShipmentByOrderIdAsync(long orderId);
        Task<Entities.Shipment> GetShipmentByOrderIdAsync(Guid uniqueOrderId);
        Task<Entities.Shipment> GetShipmentByIdAsync(long id);

    }
}
