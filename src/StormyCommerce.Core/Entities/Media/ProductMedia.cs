using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Entities.Media
{
    public class ProductMedia : Media
    {
        public long? StormyProductId { get; set; }   
        public StormyProduct Product { get; set; }          
    }
}