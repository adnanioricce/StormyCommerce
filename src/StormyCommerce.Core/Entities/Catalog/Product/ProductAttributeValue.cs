namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductAttributeValue : EntityBase
    {
        public long AttributeId { get; set; }

        public virtual ProductAttribute Attribute { get; set; }

        public long ProductId { get; set; }

        public virtual StormyProduct Product { get; set; }

        public string Value { get; set; }
    }
}
