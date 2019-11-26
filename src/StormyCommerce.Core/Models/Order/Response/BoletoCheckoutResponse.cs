using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Models.Order.Response
{
    public class BoletoCheckoutResponse
    {
        public string BoletoUrl { get; set; }
        public string BoletoBarcode { get; set; }
        public Result<OrderDto> Result { get; set; }
    }
}
