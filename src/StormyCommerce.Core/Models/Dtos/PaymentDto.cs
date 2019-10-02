using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos
{
    public class PaymentDto
    {
        public PaymentDto()
        {
            
        }
        public decimal Amount { get; private set; }
        public string CardHash { get; private set; }
        public string CardId { get; private set; }
        public string CardHolderName { get; private set; }
        public string ExpirationDate { get; private set; }
        public string CardNumber { get; private set; }
        public string CardCvv { get; private set; }
        public string PaymentMethod { get; private set; }
        public string PostbackUrl { get; private set; }
        public Address Billing { get; private set; }
        public OrderDto Order {get; private set;}
    }
}
