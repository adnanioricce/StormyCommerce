using System.Threading.Tasks;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Models.Request;
using StormyCommerce.Core.Models.Shipment.Responses;

namespace SimplCommerce.Module.Shipments.Interfaces
{
    public interface IShippingProvider
    {
        Task<DeliveryCalculationResponse> CalculateDeliveryPriceAndTime(DeliveryCalculationRequest request);
        Task<DeliveryCalculationResponse> DefaultDeliveryCalculation(Shipment shipment);
    }
}
