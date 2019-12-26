using StormyCommerce.Core.Entities.Catalog.Product;
using System;

namespace StormyCommerce.Core.Entities.Customer
{
    public class WishlistItem : EntityBase
    {
        public long ProductId { get; set; }
        public virtual StormyProduct Product { get; set; }
        public long WishlistId { get; set; }
        public virtual Wishlist Wishlist { get; set; }
        public DateTimeOffset AddedAt { get; set; }        
    }
}
