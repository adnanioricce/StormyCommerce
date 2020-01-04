﻿using System;
using SimplCommerce.Module.Payments.Models;

namespace StormyCommerce.Module.Payments.Models.Dtos
{
    public class PaymentDto
    {
        public PaymentDto()
        {
            
        }
        public PaymentDto(Payment payment)
        {
            Amount = payment.Amount;
            CreatedOn = payment.CreatedOn;
            PaidOutAt = payment.PaidOutAt;
            PaymentFee = payment.PaymentFee;
            PaymentMethod = payment.Method;
            GatewayTransactionId = payment.GatewayTransactionId;
            Status = payment.Status;
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
        public PaymentStatus Status { get; private set; }
        public string FailureMessage { get; private set; }
        public string BoletoBarcode { get; private set; }
        public string BoletoUrl { get; private set; }

    }
}
