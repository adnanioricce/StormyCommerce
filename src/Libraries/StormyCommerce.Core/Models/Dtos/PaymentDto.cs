using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos
{
    public class PaymentDto
    {
        public PaymentDto()
        {
            
        }
        public decimal Amount { get; private set; }                      
        public OrderDto Order {get; private set;}        
        public DateTimeOffset CreatedOn { get; set; }        
        public decimal PaymentFee { get; set; }
        public string PaymentMethod { get; set; }
        public string GatewayTransactionId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string FailureMessage { get; set; }
    }
}
