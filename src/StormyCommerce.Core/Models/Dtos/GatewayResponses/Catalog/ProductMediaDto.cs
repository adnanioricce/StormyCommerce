using StormyCommerce.Core.Entities.Media;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class ProductMediaDto
    {
        public ProductMediaDto(){}
        public ProductMediaDto(ProductMedia media)
        {
            Filename = media.FileName;
            FileSize = media.FileSize;
            SeoFilename = media.SeoFileName;
        }
        public string Filename { get; set; }
        public int FileSize { get; set; }
        public string SeoFilename { get; set; }
    }
}
