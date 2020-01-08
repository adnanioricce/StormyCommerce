using System;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.ShoppingCart.Models
{
    public class CartItem : EntityBase
    {        
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public long CartId { get; set; }

        public Cart Cart { get; set; }
    }
}
