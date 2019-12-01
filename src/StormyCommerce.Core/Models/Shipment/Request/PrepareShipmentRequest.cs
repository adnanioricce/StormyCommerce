using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Models.Shipment.Request
{
    public class PrepareShipmentRequest
    {
        public decimal TotalPrice { get; set; }        
        public OrderDto Order { get; set; }
        public string DestinationPostalCode { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
    }
}
