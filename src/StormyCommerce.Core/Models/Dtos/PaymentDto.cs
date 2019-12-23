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
        public PaymentDto(StormyPayment payment)
        {
            Amount = payment.Amount;
            CreatedOn = payment.CreatedOn;
            PaidOutAt = payment.PaidOutAt;
            PaymentFee = payment.PaymentFee;
            PaymentMethod = payment.PaymentMethod;
            GatewayTransactionId = payment.GatewayTransactionId;
            PaymentStatus = payment.PaymentStatus;
            FailureMessage = payment.FailureMessage;
            BoletoBarcode = payment.BoletoBarcode;
            BoletoUrl = payment.BoletoUrl;
        }
        public decimal Amount { get; private set; }                                      
        public DateTimeOffset CreatedOn { get; private set; }
        public DateTimeOffset? PaidOutAt { get; private set; }
        public decimal PaymentFee { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public string GatewayTransactionId { get; private set; }
        public PaymentStatus PaymentStatus { get; private set; }
        public string FailureMessage { get; private set; }
        public string BoletoBarcode { get; private set; }
        public string BoletoUrl { get; private set; }

    }
}
