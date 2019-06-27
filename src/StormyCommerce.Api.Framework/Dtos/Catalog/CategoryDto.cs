using System.Collections.Generic;

namespace StormyCommerce.Api.Framework.Dtos
{
    public class CategoryDto
    {        
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public IList<CategoryDto> Children { get; private set; }
        public CategoryDto Parent { get; private set; }
        public string Description { get; private set; }
        public string ThumbnailImage { get; private set; }
    }
}
