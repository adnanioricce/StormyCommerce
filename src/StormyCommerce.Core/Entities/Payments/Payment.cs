using System;

namespace StormyCommerce.Core.Entities.Payments
{
    public class Payment : BaseEntity
    {
        public Payment(long id)
        {
            Id = id;
        }

        public Payment(){}

        public long StormyOrderId { get; set; }
        public StormyOrder Order { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public decimal Amount { get; set; }
        public decimal PaymentFee { get; set; }
        public string PaymentMethod { get; set; }
        public string GatewayTransactionId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string FailureMessage { get; set; }
    }
}
