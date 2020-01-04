
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.Orders.Models.Dtos;

namespace StormyCommerce.Module.Payments.Models.Requests
{
    public class ChargeBoletoRequest
    {
        public decimal Amount { get; set; }
        public OrderDto Order { get; set; }
        public decimal PaymentFee { get; set; }
        public string GatewayTransactionId { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
