using StormyCommerce.Module.Catalog.Dtos;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class CategoryDto
    {        
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public int DisplayOrder { get; private set; }
        public IList<CategoryDto> Children { get; private set; }
        public CategoryDto Parent { get; private set; }
        public string Description { get; private set; }
        public MediaDto ThumbnailImage { get; private set; }
    }
}
