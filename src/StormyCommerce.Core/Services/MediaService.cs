using System.IO;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Interfaces;
namespace StormyCommerce.Core.Services
{
    public class MediaService : IMediaService
    {
        public Task DeleteMediaAsync(Media media)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteMediaAsync(string filename)
        {
            throw new System.NotImplementedException();
        }

        public string GetMediaUrl(Media media)
        {
            throw new System.NotImplementedException();
        }

        public string GetMediaUrl(string filename)
        {
            throw new System.NotImplementedException();
        }

        public string GetThumbnailUrl(Media media)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveMediaAsync(Stream mediaBinaryStream, string filename, string mimeType = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
