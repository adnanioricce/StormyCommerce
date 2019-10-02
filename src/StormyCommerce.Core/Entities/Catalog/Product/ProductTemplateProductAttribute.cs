namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductTemplateProductAttribute
    {
        public long ProductTemplateId { get; set; }

        public ProductTemplate ProductTemplate { get; set; }

        public long ProductAttributeId { get; set; }

        public ProductAttribute ProductAttribute { get; set; }
    }
}
