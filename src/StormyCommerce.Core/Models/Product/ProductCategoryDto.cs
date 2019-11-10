using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Models
{
    public class ProductCategoryDto
    {
        public ProductCategoryDto(){}
        public ProductCategoryDto(ProductCategory productCategory)
        {
            Category = new CategoryDto(productCategory.Category);            
        }
        public ProductCategoryDto(Category category)
        {
            Category = new CategoryDto(category);
        }
        public CategoryDto Category { get; private set; }
    }
}
