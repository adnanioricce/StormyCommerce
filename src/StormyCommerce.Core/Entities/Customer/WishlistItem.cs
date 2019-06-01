using StormyCommerce.Core.Entities.Product;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormyCommerce.Core.Entities.Customer
{
    public class WishlistItem : BaseEntity
    {
        public int ProductInt { get; set; }
        [NotMapped]
        public StormyProduct Product { get; set; }
        public DateTime AddedAt { get; set; }
        public bool Deleted { get; set; }
    }
}
