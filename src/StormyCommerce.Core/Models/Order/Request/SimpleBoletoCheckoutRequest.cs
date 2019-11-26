using System.Collections.Generic;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Order;

namespace StormyCommerce.Core.Models.Order
{
    public class SimpleBoletoCheckoutRequest
    {
        public decimal Amount { get; set; }
        public string PaymentMethod { get; } = "boleto";
        public bool PickUpOnStore { get; set; }
        public List<CartItem> Items { get; set; }
    }
}
