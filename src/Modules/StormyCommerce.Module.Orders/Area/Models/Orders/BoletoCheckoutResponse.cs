using System;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Module.Orders.Area.Models.Orders
{
    public class BoletoCheckoutResponse
    {
        public string BoletoUrl { get; set; }
        public string BoletoBarcode { get; set; }        
        public Result<OrderDto> Result { get; set; }
    }
}
