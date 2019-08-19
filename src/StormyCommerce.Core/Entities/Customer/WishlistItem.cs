﻿using StormyCommerce.Core.Entities.Catalog.Product;
using System;

namespace StormyCommerce.Core.Entities.Customer
{
    public class WishlistItem : BaseEntity
    {
        public int ProductId { get; set; }               
        public StormyProduct Product { get; set; }
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
        public DateTime AddedAt { get; set; }
        public bool Deleted { get; set; }
    }
}