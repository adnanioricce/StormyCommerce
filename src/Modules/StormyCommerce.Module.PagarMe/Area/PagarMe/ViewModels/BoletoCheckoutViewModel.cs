using System;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities.Common;
namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class BoletoCheckoutViewModel
    {
        [Required]
        public int Amount { get; set; } 
        [Required]
        public string CustomerFullName { get; set; }
        [Required]        
        public Address Billing { get; set; }
    }
}
