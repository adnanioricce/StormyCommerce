using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.ShoppingCart.Models;

namespace StormyCommerce.Module.Payments.Models.Requests
{
    public class CheckoutCreditCardRequest
    {
        [Required]
        [Range(1, 9999999)]
        public decimal Amount { get; set; }
        public ShippingMethod ShippingMethod { get; set; }        
        public bool PickUpOnStore { get; set; }
        [Required]
        [MinLength(1)]
        public List<CartItem> Items { get; set; }        
        public string PostalCode { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CardExpirationDate { get; set; }
        public string CardCvv { get; set; }
    }
}
