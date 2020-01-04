using System.Collections.Generic;
namespace StormyCommerce.Core.Models.Shipment.Responses
{
    public class DeliveryCalculationResponse
    {
        public List<DeliveryCalculationOptionResponse> Options { get; set; }
    }
}
