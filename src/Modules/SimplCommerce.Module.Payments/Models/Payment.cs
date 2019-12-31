using System;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Module.Orders.Models;
using StormyCommerce.Core.Entities;
namespace SimplCommerce.Module.Payments.Models
{
    public class Payment : EntityBase
    {
        public Payment()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public long OrderId { get; set; }

        public Order Order { get; set; }

        public DateTimeOffset? PaidOutAt { get; set; }

        public decimal Amount { get; set; }

        public decimal PaymentFee { get; set; }        

        [StringLength(450)]
        public string GatewayTransactionId { get; set; }

        public PaymentStatus Status { get; set; }

        public string FailureMessage { get; set; }
                        
        public PaymentMethod PaymentMethod { get; set; }                        
        public string BoletoUrl { get; set; }
        public string BoletoBarcode { get; set; }
    }
}
