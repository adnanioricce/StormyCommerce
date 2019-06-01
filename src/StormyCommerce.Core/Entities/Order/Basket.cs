using System.Collections.Generic;
using StormyCommerce.Core.Entities.Product;

namespace StormyCommerce.Core.Entities.Order
{
    public class Basket
    {
        public int? Id { get; set; }
        private readonly List<StormyProduct> _items = new List<StormyProduct>();
        public IReadOnlyCollection<StormyProduct> Items => _items.AsReadOnly();
        
        public decimal TotalPrice { get; set; }                
    }
}
