using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Order.Request;

namespace StormyCommerce.Core.Models.Shipment.Request
{
    public class PrepareShipmentRequest
    {
        public PrepareShipmentRequest()
        {

        }
        public PrepareShipmentRequest(OrderDto order,CheckoutRequest request)
        {
            Order = order;
            DestinationPostalCode = request.PostalCode;
            ShippingMethod = request.ShippingMethod;
            TotalPrice = order.TotalPrice;
        }
        public decimal TotalPrice { get; set; }        
        public OrderDto Order { get; set; }
        public string DestinationPostalCode { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
    }
}
