using SimplCommerce.Module.Core.Models;

namespace StormyCommerce.Module.Catalog.Models.Dtos
{
    public class MediaDto
    {
        public MediaDto()
        {
        }

        public MediaDto(Media media)
        {
            Filename = media.FileName;
        }

        public string Filename { get; private set; }
    }
}
