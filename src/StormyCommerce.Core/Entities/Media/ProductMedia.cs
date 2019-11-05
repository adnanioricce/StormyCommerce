using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Entities.Media
{
    public class ProductMedia : BaseEntity
    {
        public long MediaId { get; set; }
        public Media Media { get; set; }
        public long? StormyProductId { get; set; }   
        public StormyProduct Product { get; set; }          
    }
}