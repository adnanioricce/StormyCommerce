namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductTemplateProductAttribute
    {
        public long ProductTemplateId { get; set; }

        public virtual ProductTemplate ProductTemplate { get; set; }

        public long ProductAttributeId { get; set; }

        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
