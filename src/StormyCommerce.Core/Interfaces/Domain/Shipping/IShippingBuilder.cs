using StormyCommerce.Core.Models.Shipment;
using StormyCommerce.Core.Models.Shipment.Response;

namespace StormyCommerce.Core.Interfaces.Domain.Shipping
{
    public interface IShippingBuilder
    {
        CalculateShippingMeasuresModel CalculateShippingMeasures(CalculateShippingMeasuresModel request);
    }
}
