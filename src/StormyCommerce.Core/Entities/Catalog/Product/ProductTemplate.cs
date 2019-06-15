using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities;
//TODO: Use FluentAPI instead of DataAnnotations
namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductTemplate : BaseEntity
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
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
