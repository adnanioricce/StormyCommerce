using System;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Models.Order
{
    [Serializable]
    public class CartItem
    {
        [Required]        
        public long StormyProductId { get; set; }        
        [Required]        
        public int Quantity { get; set; }        
    }
}
