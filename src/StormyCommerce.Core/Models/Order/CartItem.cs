using System;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Models.Order
{
    [Serializable]
    public class CartItem
    {
        [Required]
        [Range(1,long.MaxValue)]
        public long StormyProductId { get; set; }        
        [Required]        
        public int Quantity { get; set; }        
    }
}
