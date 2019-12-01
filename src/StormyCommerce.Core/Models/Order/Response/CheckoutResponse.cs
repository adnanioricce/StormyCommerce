using System;
using System.Collections.Generic;
using System.Text;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Shipping;

namespace StormyCommerce.Core.Models.Order.Response
{
    [Serializable]
    public class CheckoutResponse
    {
        public CheckoutResponse(){}
        public CheckoutResponse(OrderDto order)
        {
            Order = order;
            Payment = order.Payment;
            Shipment = order.Shipment;
        }
        public PaymentDto Payment { get; set; }
        public ShipmentDto Shipment { get; set; }
        public OrderDto Order { get; set; }
    }
}
