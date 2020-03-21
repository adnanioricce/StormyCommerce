using System.Collections.Generic;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Models;

namespace SimplCommerce.Module.Payments.Models
{
    public class ProcessTransactionRequest
    {
        public long CartId { get; set; }   
        public long UserId { get; set; }
        public long AddressId { get; set; }
        public long OrderId { get; set; }
        public decimal TotalAmount { get; set; }                
        public List<OrderItem> Items { get; set; }
        public User User { get; set; }
        public string PaymentMethod { get; set; }
        public string CardBrand { get; set; }
        public string CardCountry { get; set; }
        public string CardExpirationMounth { get; set; }
        public string CardExpirationYear { get; set; }
        public string CardFingerPrint { get; set; }
        public string CardFunding { get; set; }        
    }   
}
