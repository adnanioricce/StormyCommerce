using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Module.Catalog.Dtos;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class CategoryDto
    {
        public CategoryDto(Category category)
        {
            Name = category.Name;
            Slug = category.Slug;
            DisplayOrder = category.DisplayOrder;
            Childrens = category.ToCategoryDtoChildrens();
            Parent = new CategoryDto(category.Parent);
            Description = category.Description;
            ThumbnailImage = new MediaDto(category.ThumbnailImage);
        }
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public int DisplayOrder { get; private set; }
        public IList<CategoryDto> Childrens { get; private set; }
        public CategoryDto Parent { get; private set; }
        public string Description { get; private set; }
        public MediaDto ThumbnailImage { get; private set; }
    }
}
