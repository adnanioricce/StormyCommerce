namespace StormyCommerce.Core.Entities.Product
{
    public class ProductType : BaseEntity
    {        
        public string Name { get; set; }
        public ProductDetail Details { get; set; }
    }
}