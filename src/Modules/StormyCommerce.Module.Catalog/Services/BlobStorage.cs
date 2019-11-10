using System.Diagnostics.Contracts;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace StormyCommerce.Module.Catalog.Services
{
    public class BlobStorage : IStorageService
    {
        private CloudBlobContainer _blobContainer;
        private string _publicEndpoint;
        public BlobStorage()
        {
            string storageConnectionString = Container.Configuration["Azure:Blob:StorageConnectionString"];
            string containerName = Container.Configuration["Azure:Blob:ContainerName"];
            _publicEndpoint = Container.Configuration["Azure:Blob:PublicEndpoint"];
            Contract.Requires(string.IsNullOrEmpty(storageConnectionString));
            Contract.Requires(string.IsNullOrEmpty(containerName));
            var storageAccount = CloudStorageAccount.Parse(storageConnectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
            _blobContainer = blobClient.GetContainerReference(containerName);
            if (string.IsNullOrWhiteSpace(_publicEndpoint))
            {
                _publicEndpoint = _blobContainer.Uri.AbsoluteUri;
            }
        }
        public async Task DeleteMediaAsync(string fileName)
        {
            var blockBlob = _blobContainer.GetBlockBlobReference(fileName);
            await blockBlob.DeleteIfExistsAsync();
        }

        public string GetMediaUrl(string fileName)
        {
            return $"{_publicEndpoint}/{fileName}";
        }

        public async Task SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null)
        {
            await _blobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Container });
            await _blobContainer.CreateIfNotExistsAsync();

            var blockBlob = _blobContainer.GetBlockBlobReference(fileName);
            await blockBlob.UploadFromStreamAsync(mediaBinaryStream);
        }
    }
}
