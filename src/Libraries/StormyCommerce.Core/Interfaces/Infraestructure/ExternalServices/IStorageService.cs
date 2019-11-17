using System.IO;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Infraestructure.Data
{
    public interface IStorageService
    {
        string GetMediaUrl(string fileName);

        Task SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null);

        Task DeleteMediaAsync(string fileName);
    }
}
