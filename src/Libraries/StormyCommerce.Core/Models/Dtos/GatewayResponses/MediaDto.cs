using StormyCommerce.Core.Entities.Media;

namespace StormyCommerce.Module.Catalog.Dtos
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
