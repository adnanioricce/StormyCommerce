using System.Collections.Generic;

//TODO: Use FluentAPI instead of DataAnnotations
namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductTemplate : BaseEntity
    {
        public string Name { get; set; }

        public IList<ProductTemplateProductAttribute> ProductAttributes { get; protected set; } = new List<ProductTemplateProductAttribute>();

        public void AddAttribute(long attributeId)
        {
            var productTempateProductAttribute = new ProductTemplateProductAttribute
            {
                ProductTemplate = this,
                ProductAttributeId = attributeId
            };
            ProductAttributes.Add(productTempateProductAttribute);
        }
    }
}
