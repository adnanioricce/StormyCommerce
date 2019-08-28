using StormyCommerce.Core.Entities.Catalog.Product;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductAttribute : BaseEntity
    {   
	    public long GroupId { get; set; } 
	    public ProductAttributeGroup Group { get; set;}
        public string Name { get; set; }
	    public IList<ProductTemplateProductAttribute> ProductTemplates {get; private set;} = new List<ProductTemplateProductAttribute>();
    }
}
