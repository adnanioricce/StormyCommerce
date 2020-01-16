using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;

namespace SimplCommerce.Module.Core.Services
{
    public class MediaService : IMediaService
    {
        private readonly IRepository<Media> _mediaRepository;
        private readonly IStorageService _storageService;

        public MediaService(IRepository<Media> mediaRepository, IStorageService storageService)
        {
            _mediaRepository = mediaRepository;
            _storageService = storageService;
        }

        public virtual string GetMediaUrl(Media media)
        {
            if(media == null)
            {
                return GetMediaUrl("no-image.png");
            }

            return GetMediaUrl(media.FileName);
        }

        public virtual string GetMediaUrl(string fileName)
        {
            return _storageService.GetMediaUrl(fileName);
        }

        public virtual string GetThumbnailUrl(Media media)
        {
            return GetMediaUrl(media);
        }

        public virtual Task SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null)
        {
            return _storageService.SaveMediaAsync(mediaBinaryStream, fileName, mimeType);
        }

        public virtual Task DeleteMediaAsync(Media media)
        {
            _mediaRepository.Remove(media);
            return DeleteMediaAsync(media.FileName);
        }

        public virtual Task DeleteMediaAsync(string fileName)
        {
            return _storageService.DeleteMediaAsync(fileName);
        }                
    }
}
