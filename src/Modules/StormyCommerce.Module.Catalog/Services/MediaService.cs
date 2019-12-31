using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

//Just Copy and Paste from the original
//Tried to avoid adding a reference from Module.Core just for this class
namespace StormyCommerce.Module.Catalog.Services
{
    public class MediaService : IMediaService
    {
        private readonly IStormyRepository<Media> _mediaRepository;
        private readonly IStorageService _storageService;
        private readonly string[] allowedExtensions = { ".png", ".jpg", ".jpeg" };
        public MediaService(IStormyRepository<Media> mediaRepository,
        IStorageService storageService)
        {
            _mediaRepository = mediaRepository;
            _storageService = storageService;
        }
        public Media GetMediaByFilename(string fileName)
        {
            return _mediaRepository.Query()
                .Where(f => string.Equals(fileName, f.FileName))
                .SingleOrDefault();
        }
        public string GetMediaUrl(Media media)
        {
            if (media == null)
            {
                return GetMediaUrl("no-image.png");
            }

            return GetMediaUrl(media.FileName);
        }

        public string GetMediaUrl(string fileName)
        {
            return _storageService.GetMediaUrl(fileName);
        }

        public string GetThumbnailUrl(Media media)
        {
            return GetMediaUrl(media);
        }

        public async Task SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();               
            if (string.IsNullOrEmpty(extension) || !allowedExtensions.Contains(extension))
                 await Task.FromCanceled(System.Threading.CancellationToken.None);
            await _mediaRepository.AddAsync(new Media
            {
                FileName = fileName,
                MediaType = MediaType.Image,
                FileSize = mediaBinaryStream.Length                
            });
            await _storageService.SaveMediaAsync(mediaBinaryStream, fileName, mimeType);
        }

        public Task DeleteMediaAsync(Media media)
        {
            _mediaRepository.Delete(media);
            return DeleteMediaAsync(media.FileName);
        }

        public Task DeleteMediaAsync(string fileName)
        {
            return _storageService.DeleteMediaAsync(fileName);
        }
    }
}
