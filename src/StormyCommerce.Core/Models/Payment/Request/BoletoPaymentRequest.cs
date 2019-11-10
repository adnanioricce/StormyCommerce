
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Models.Payment.Request
{
    public class BoletoPaymentRequest
    {
        public decimal Amount { get; set; }
        public OrderDto Order { get; set; }
        public decimal PaymentFee { get; set; }
        public string GatewayTransactionId { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
