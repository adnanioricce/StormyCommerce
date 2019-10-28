using System;
using System.Collections.Generic;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Module.Orders.Area.Models.Shipping
{
    public class DeliveryCalculationForOrderRequest
    {
        public string DestinationPostalCode { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }
}
