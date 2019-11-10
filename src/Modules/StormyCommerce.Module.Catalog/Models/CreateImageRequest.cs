using Microsoft.AspNetCore.Http;

namespace StormyCommerce.Module.Catalog.Models
{
    public class CreateImageRequest
    {
        public string Filename { get; set; }
        public IFormFile File { get; set; }
    }
}
