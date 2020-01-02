using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Module.ShoppingCart.Models;
using StormyCommerce.Core.Entities.Shipping;

namespace StormyCommerce.Module.Payments.Models.Requests
{
    [Serializable]
    public class CheckoutBoletoRequest
    {
        [Required]
        [Range(1, 9999999)]
        public decimal Amount { get; set; }
        
        public ShippingMethod ShippingMethod { get; set; }
        public bool PickUpOnStore { get; set; }
        [Required]
        [MinLength(1)]
        public List<CartItem> Items { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PostalCode { get; set; }                

    }
}
