using System;
using SimplCommerce.Module.Shipments.Models.Dtos;
using StormyCommerce.Module.Orders.Models.Dtos;
using StormyCommerce.Module.Payments.Models.Dtos;

namespace SimplCommerce.Module.Orders.Models.Responses
{
    [Serializable]
    public class CreditCardCheckoutResponse
    {
        public PaymentDto Payment { get; set; }
        public ShipmentDto Shipment { get; set; }
        public OrderDto Order { get; set; }        
    }
}
