using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductAttributeValue
    {
        public long AttributeId { get; set; }

        public ProductAttribute Attribute { get; set; }

        public long ProductId { get; set; }

        public StormyProduct Product { get; set; }

        public string Value { get; set; }
    }
}
