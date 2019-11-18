using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Entities.Media
{
    public class ProductMedia : BaseEntity
    {
        public long MediaId { get; set; }
        public virtual Media Media { get; set; }
        public long? StormyProductId { get; set; }   
        public virtual StormyProduct Product { get; set; }          
    }
}
