using StormyCommerce.Core.Entities.Product;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Catalog.Shirt
{
    public class Shirt : StormyProduct
    {
        //?How I Map this to a table?
        public ICollection<ShirtSize> AvailableSizes { get; set; }
        public ICollection<ShirtGender> Genders { get; set; }
        public ICollection<Color> Color { get; set; }
    }
}
