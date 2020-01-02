using System;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Shipping;
using StormyCommerce.Module.Payments.Models.Dtos;

namespace StormyCommerce.Module.Orders.Models.Responses
{
    [Serializable]
    public class CheckoutResponse
    {
        public CheckoutResponse(){}
        public CheckoutResponse(OrderDto order)
        {
            Order = order;           
        }
        public CheckoutResponse(OrderDto order,PaymentDto payment,ShipmentDto shipment) : this(order)
        {
            Payment = payment;
            Shipment = shipment;
        }
        public PaymentDto Payment { get; set; }
        public ShipmentDto Shipment { get; set; }
        public OrderDto Order { get; set; }
    }
}
