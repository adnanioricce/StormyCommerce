using System.Collections.Generic;

namespace StormyCommerce.Module.Catalog.Dtos
{
    public class CategoryDto
    {
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public int DisplayOrder { get; private set; }
        public IList<CategoryDto> Childrens { get; private set; }
        public string Description { get; private set; }
        public MediaDto ThumbnailImage { get; private set; }
    }
}
