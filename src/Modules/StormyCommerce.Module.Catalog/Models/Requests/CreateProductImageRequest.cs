using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace StormyCommerce.Module.Catalog.Models
{
    public class CreateProductImageRequest
    {
        [Required]
        public long ProductId  { get; set; }        
        [Required]        
        public IFormFile File { get; set; }
        public string ImageName { get; set; }
    }
}
