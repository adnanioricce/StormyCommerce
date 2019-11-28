using System.Collections.Generic;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Models.Shipment
{
    public class CalculateShippingMeasuresRequest
    {
        public OrderDto Order { get; set; }
        public string DestinationPostalCode { get; set; }
    }
}
