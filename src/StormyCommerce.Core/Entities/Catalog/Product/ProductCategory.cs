using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog;
namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductCategory : EntityBase
    {
        public int DisplayOrder { get; set; }
        public long CategoryId { get; set; }
        public long ProductId { get; set; }
        public virtual Category Category { get; set; }
        public virtual StormyProduct Product { get; set; }
    }
}
