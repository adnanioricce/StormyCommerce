using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductAttribute : EntityBase
    {
        public long GroupId { get; set; }
        public virtual ProductAttributeGroup Group { get; set; }
        public string Name { get; set; }
        public virtual IList<ProductTemplateProductAttribute> ProductTemplates { get; private set; } = new List<ProductTemplateProductAttribute>();
    }
}
