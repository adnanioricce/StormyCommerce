namespace StormyCommerce.Core.Entities.Product
{
    public class ProductDetail : BaseEntity
    {        
        public Category Category { get; set; }
        public Category Parent { get; set; }
        public ProductAttribute Attribute { get; set; }
    }
}