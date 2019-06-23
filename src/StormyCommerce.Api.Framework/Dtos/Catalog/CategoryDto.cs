using System.Collections.Generic;

namespace StormyCommerce.Api.Framework.Dtos
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public IList<CategoryDto> SubCategories { get; set; }
        public string Description { get; set; }
        public string UrlThumbnail { get; set; }
    }
}
