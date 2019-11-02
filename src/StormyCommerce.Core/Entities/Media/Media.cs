using StormyCommerce.Module.Catalog.Dtos;

namespace StormyCommerce.Core.Entities.Media
{
    public class Media : BaseEntity
    {
        public string Caption { get; set; }
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public MediaType MediaType { get; set; }
        public string SeoFileName { get; set; }        
        public MediaDto ToMediaDto()
        {
            return new MediaDto(this);
        }
    }
}
