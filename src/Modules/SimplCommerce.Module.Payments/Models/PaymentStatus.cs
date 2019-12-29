namespace SimplCommerce.Module.Payments.Models
{
    public enum PaymentStatus
    {
        Successful = 1,
        Failed = 5,
        Processing = 10,
        Pending = 15,        
        Authorized = 20,
        PartiallyRefunded = 25,
        Refunded = 30
    }
}
