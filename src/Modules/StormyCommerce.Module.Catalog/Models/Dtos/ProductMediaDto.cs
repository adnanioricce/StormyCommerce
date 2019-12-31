using StormyCommerce.Core.Entities.Media;

namespace StormyCommerce.Module.Catalog.Models.Dtos
{
    public class ProductMediaDto
    {
        public ProductMediaDto(){}
        public ProductMediaDto(Media media)
        {
            FileName = media.FileName;
            FileSize = media.FileSize;
            SeoFilename = media.SeoFileName;
        }
        public ProductMediaDto(ProductMedia media)
        {
            FileName = media.Media.FileName;
            FileSize = media.Media.FileSize;
            SeoFilename = media.Media.SeoFileName;
        }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string SeoFilename { get; set; }
    }
}
