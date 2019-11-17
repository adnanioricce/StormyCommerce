namespace StormyCommerce.Core.Entities.Payments
{
    public enum PaymentStatus
    {
        Successful = 1,
        Failed = 5,
        Pending = 15,
        Authorized = 20,
        PartiallyRefunded = 25,
        Refunded = 30
    }
}
