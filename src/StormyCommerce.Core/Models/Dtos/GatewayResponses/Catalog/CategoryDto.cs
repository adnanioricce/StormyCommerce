using StormyCommerce.Core.Entities.Catalog;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class CategoryDto
    {
        public CategoryDto(){}

        public CategoryDto(Category category)
        {
            Id = category.Id;
            Name = category.Name;
            Slug = category.Slug;
            DisplayOrder = category.DisplayOrder;                        
            Description = category.Description;
            ThumbnailImageUrl = category.ThumbnailImageUrl;
        }

        public long? Id { get; private set; } = 0;
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public int DisplayOrder { get; private set; }                
        public string Description { get; private set; }
        public string ThumbnailImageUrl { get; private set; }
    }
}
