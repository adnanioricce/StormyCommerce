using System;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Shipping;

namespace StormyCommerce.Core.Models.Order.Response
{
    [Serializable]
    public class CreditCardCheckoutResponse
    {
        public PaymentDto Payment { get; set; }
        public ShipmentDto Shipment { get; set; }
        public OrderDto Order { get; set; }        
    }
}
