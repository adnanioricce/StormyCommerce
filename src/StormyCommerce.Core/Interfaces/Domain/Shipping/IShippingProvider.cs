using System.Threading.Tasks;
using StormyCommerce.Core.Models.Shipment.Response;
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Core.Entities.Shipping;
namespace StormyCommerce.Core.Interfaces.Domain.Shipping
{
    public interface IShippingProvider
    {
        Task<DeliveryCalculationResponse> CalculateDeliveryPriceAndTime(DeliveryCalculationRequest request);
        Task<DeliveryCalculationResponse> DefaultDeliveryCalculation(Entities.Shipping.StormyShipment shipment);
    }
}
