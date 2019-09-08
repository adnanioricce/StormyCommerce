using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Product
{
    public class ProductDetail : BaseEntity
    {
        public Category Category { get; set; }
        public Category Parent { get; set; }
        public IList<ProductAttribute> Attribute { get; set; }
    }
}
