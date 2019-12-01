
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;

namespace StormyCommerce.Core.Models.Order.Request
{
    [Serializable]
    public class CheckoutRequest
    {
        [Required]
        [Range(1, 9999999)]
        public decimal Amount { get; set; }
        
        public ShippingMethod ShippingMethod { get; set; }
        public bool PickUpOnStore { get; set; }
        [Required]
        public List<CartItem> Items { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PostalCode { get; set; }
        public string CardHash { get; set; }
       
    }
}
