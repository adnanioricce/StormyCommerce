using StormyCommerce.Core.Models.Shipment;
using StormyCommerce.Core.Models.Shipment.Responses;

namespace SimplCommerce.Module.Shipments.Interfaces
{
    public interface IShippingBuilder
    {
        CalculateShippingMeasuresModel CalculateShippingMeasures(CalculateShippingMeasuresModel request);
    }
}
