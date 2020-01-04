using SimplCommerce.Module.Shipments.Models;
using StormyCommerce.Module.Orders.Models.Dtos;

namespace SimplCommerce.Module.Shipments.Requests
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
            OrderTotal = order.OrderTotal;
        }
        public decimal OrderTotal { get; set; }        
        public OrderDto Order { get; set; }
        public string DestinationPostalCode { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
    }
}
