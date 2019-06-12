namespace StormyCommerce.Core.Entities.Product
{
    public class ProductAttribute : BaseEntity
    {   
	public long GroupId { get; set; } 
	public ProductAttributeGroup Group { get; set;}
        public string Name { get; set; }
	public IList<ProductTemplateProductAttribute> ProductTemplates {get; private set;} = new List<ProductTemplateProductAttribute>();
    }
}
