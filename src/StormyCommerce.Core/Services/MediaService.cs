using StormyCommerce.Core.Interfaces;
using System.Threading.Tasks;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
namespace StormyCommerce.Core.Services
{
	public class MediaService : IMediaService
	{
		private readonly IStorageService storageService; 
		private readonly IStormyRepository<Media> mediaRepository;
		public MediaService(IStorageService _storageService,IStormyRepository<Media> _mediaRepository)
		{
			storageService = _storageService;
			mediaRepository = _mediaRepository;
		}
		public string GetMediaUrl(Media media)
		{
			if(media == null)
				return GetMediaUrl("no-image.png");

			return GetMediaUrl(media.Filename); 
		}
		public string GetMediaUrl(string fileName); 
		{
			return _storageService.GetMediaUrl(fileName);
		}
		public string GetThumbnail(Media media)
		{
			return GetMediaUrl(media);
		}
		public Task SaveMediaAsync(Stream mediaBinaryStream,string filename,string mimeType = null)
		{
			return storageService.SaveMediaAsync(mediaBinaryStream,filename,mimeType); 
		}
		public async Task DeleteMediaAsync(Media media)
		{
			mediaRepository.Delete(media);
			return await DeleteMediaAsync(media.Filename);
		}
		public async Task DeleteMediaAsync(string filename)
		{
			return await storageService.DeleteMediaAsync(filename);
		}


	}
}
