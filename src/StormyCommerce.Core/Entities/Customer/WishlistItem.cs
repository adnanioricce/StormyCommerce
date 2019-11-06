using StormyCommerce.Core.Entities.Catalog.Product;
using System;

namespace StormyCommerce.Core.Entities.Customer
{
    public class WishlistItem : BaseEntity
    {
        public long ProductId { get; set; }
        public StormyProduct Product { get; set; }
        public long WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
        public DateTime AddedAt { get; set; }        
    }
}
