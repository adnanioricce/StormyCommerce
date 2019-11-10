namespace StormyCommerce.Module.Orders.Area.Models.Orders
{
    public class SimpleBoletoCheckoutRequest
    {
        public decimal Amount { get; set; }
        public string PaymentMethod { get; } = "boleto";        
    }
}
