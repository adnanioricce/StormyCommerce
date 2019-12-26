using System;

namespace StormyCommerce.Core.Entities.Payments
{
    public class StormyPayment : EntityBase
    {
        public StormyPayment(long id)
        {
            Id = id;
        }
        public StormyPayment(){}
        public long StormyOrderId { get; set; }
        //public virtual StormyOrder Order { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? PaidOutAt { get; set; }
        public decimal Amount { get; set; }
        public decimal PaymentFee { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string GatewayTransactionId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string FailureMessage { get; set; }
        public string BoletoUrl { get; set; }
        public string BoletoBarcode { get; set; }
    }
}
