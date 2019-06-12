namespace StormyCommerce.Core.Entities.Catalog.Product
{
	public class ProductAttributeGroup : EntityBase
	{	
        	[Required(ErrorMessage = "The {0} field is required.")]
	        [StringLength(450)]
        	public string Name { get; set; }

	        public IList<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
	}

}
