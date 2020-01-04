using SimplCommerce.Module.Catalog.Models;

namespace SimplCommerce.Module.Catalog.Models.Dtos
{
    public class ProductCategoryDto
    {
        public ProductCategoryDto(){}
        public ProductCategoryDto(ProductCategory productCategory)
        {
            Category = productCategory == null ? this.Category : new CategoryDto(productCategory.Category);            
        }
        public ProductCategoryDto(Category category)
        {
            Category = category == null ? this.Category : new CategoryDto(category);
        }
        public CategoryDto Category { get; private set; } = new CategoryDto();
    }
}
