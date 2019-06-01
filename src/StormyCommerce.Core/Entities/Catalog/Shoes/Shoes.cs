using StormyCommerce.Core.Entities.Product;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Catalog.Shoes
{
    public class Shoes : StormyProduct
    {
        public ICollection<ShoesSize> AvailableSizes { get; set; }
        public ICollection<Color> AvailableColors { get; set; }

    }
}
