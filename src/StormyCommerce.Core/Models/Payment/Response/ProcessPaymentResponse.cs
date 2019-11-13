namespace StormyCommerce.Core.Models.Payment.Response
{
    public class ProcessPaymentResponse
    {
        public string Id { get; set;}
        public string Status { get; set; }
        public decimal Amount { get; set; }        
    }
}
