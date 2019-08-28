using StormyCommerce.Core.Entities.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
	public class ProductAttributeGroup : BaseEntity
	{	
        	[Required(ErrorMessage = "The {0} field is required.")]
	        [StringLength(450)]
        	public string Name { get; set; }

	        public IList<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
	}

}
