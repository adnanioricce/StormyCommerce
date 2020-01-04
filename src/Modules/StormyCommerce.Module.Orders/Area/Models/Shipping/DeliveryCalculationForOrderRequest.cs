using System;
using System.Collections.Generic;
using StormyCommerce.Module.Orders.Models.Dtos;

namespace StormyCommerce.Module.Orders.Area.Models.Shipping
{
    public class DeliveryCalculationForOrderRequest
    {        
        public string DestinationPostalCode { get; set; }
        public OrderDto Order { get; set; }
    }
}
