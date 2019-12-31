using StormyCommerce.Core.Entities.Shipping;
 


namespace StormyCommerce.Core.Models.Shipment.Request
{
    public class PrepareShipmentRequest
    {
        public PrepareShipmentRequest()
        {

        }
        public PrepareShipmentRequest(OrderDto order,string destinationPostalCode,ShippingMethod shippingMethod)
        {
            Order = order;
            DestinationPostalCode = destinationPostalCode;
            ShippingMethod = ShippingMethod;
            TotalPrice = order.TotalPrice;
        }
        public decimal TotalPrice { get; set; }        
        public OrderDto Order { get; set; }
        public string DestinationPostalCode { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
    }
}
