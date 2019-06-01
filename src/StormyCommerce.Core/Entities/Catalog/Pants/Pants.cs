using StormyCommerce.Core.Entities.Product;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Catalog.Pants
{
    //?Why not use the ProductAttribute?
    public class Pants : StormyProduct
    {
        public ICollection<ProductAttribute> PantSizes { get; set; }
        public ICollection<ProductAttribute> Colors { get; set; }
    }
}
