using StormyCommerce.Core.Interfaces;
using System.Threading.Tasks;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Entities.Media;
using System.IO;

namespace StormyCommerce.Core.Services
{
    public class MediaService : IMediaService
    {
        private readonly IStorageService storageService;
        private readonly IStormyRepository<Media> mediaRepository;
        public MediaService(IStorageService _storageService, IStormyRepository<Media> _mediaRepository)
        {
            storageService = _storageService;
            mediaRepository = _mediaRepository;
        }
        public string GetMediaUrl(Media media)
        {
            if (media == null)
                return GetMediaUrl("no-image.png");

            return GetMediaUrl(media.FileName);
        }        
        public Task SaveMediaAsync(Stream mediaBinaryStream, string filename, string mimeType = null)
        {
            return storageService.SaveMediaAsync(mediaBinaryStream, filename, mimeType);
        }
        public async Task DeleteMediaAsync(Media media)
        {
            mediaRepository.Delete(media);
            await DeleteMediaAsync(media.FileName);
        }
        public async Task DeleteMediaAsync(string filename)
        {
            await storageService.DeleteMediaAsync(filename);
        }
        public string GetMediaUrl(string fileName)
		{
			return storageService.GetMediaUrl(fileName);
		}
        public string GetThumbnailUrl(Media media)
        {
            return GetMediaUrl(media);
        }            
    }
}
