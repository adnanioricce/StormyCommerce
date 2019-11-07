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
        Task CreateShipmentAsync(Shipment shipment);
        Task CreateShipmentAsync(StormyOrder order);                
        Shipment CalculateShipmentDimensions(StormyOrder order);     
        Task<Shipment> CalculateDeliveryCost(Shipment shipment,string serviceCode);   
        Task<Shipment> GetShipmentByOrderIdAsync(long orderId);
        Task<Shipment> GetShipmentByOrderIdAsync(Guid uniqueOrderId);

    }
}
