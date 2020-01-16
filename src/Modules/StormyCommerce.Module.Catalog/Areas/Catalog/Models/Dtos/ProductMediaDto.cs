using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Models;

namespace StormyCommerce.Module.Catalog.Models.Dtos
{
    public class ProductMediaDto
    {
        public ProductMediaDto(){}
        public ProductMediaDto(Media media)
        {
            FileName = media.FileName;
            FileSize = media.FileSize;            
        }
        public ProductMediaDto(ProductMedia media)
        {
            FileName = media.Media.FileName;
            FileSize = media.Media.FileSize;            
            MediaType = media.Media.MediaType;
        }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public MediaType MediaType { get; set; }        
    }
}
