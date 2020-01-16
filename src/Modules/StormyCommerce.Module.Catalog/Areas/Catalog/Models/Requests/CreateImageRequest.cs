using Microsoft.AspNetCore.Http;

namespace StormyCommerce.Module.Catalog.Models.Requests
{
    public class CreateImageRequest
    {
        public string Filename { get; set; }
        public IFormFile File { get; set; }
    }
}
