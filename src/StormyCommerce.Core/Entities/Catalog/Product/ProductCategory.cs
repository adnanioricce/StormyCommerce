using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog;
namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductCategory : BaseEntity
    {
        public int DisplayOrder { get; set; }
        public long CategoryId { get; set; }
        public long ProductId { get; set; }
        public Category Category { get; set; }
        public StormyProduct Product { get; set; }
    }
}