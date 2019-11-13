using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.Catalog.Models;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Module.Catalog.Areas.Catalog.Controllers
{
    [ApiController]
    [Authorize(Roles.Admin)]
    [Route("api/[Controller]")]
    public class MediaController : Controller
    {
        private readonly IMediaService _mediaService;
        private readonly IProductService _productService;
        
        public MediaController(IMediaService mediaService, IProductService productService)
        {
            _mediaService = mediaService;
            _productService = productService;
        }
        [HttpPost("upload")]
        [ValidateModel]
        public async Task<IActionResult> UploadMediaFile([FromForm]CreateImageRequest model)
        {
            using (var stream = model.File.OpenReadStream())
            {
                await _mediaService.SaveMediaAsync(stream, model.Filename);                
            }
            return Ok( new { result = Result<Media>.Ok(_mediaService.GetMediaUrl(model.Filename)) });            
        }
        [HttpPost("add_image")]
        [ValidateModel]        
        public async Task<IActionResult> AddProductImage([FromBody]CreateProductImageRequest _model)
        {
            var product = await _productService.GetProductByIdAsync(_model.ProductId);
            if (_model.File.Length <= 0) return BadRequest(Result.Fail("we can't upload a empty file"));

            var isNamed = String.IsNullOrEmpty(_model.ImageName);
            var mediaName = isNamed ? _model.ImageName : $"{product.Slug}-{DateTime.UtcNow}";
            using (var stream = _model.File.OpenReadStream())
            {                
                await _mediaService.SaveMediaAsync(stream, mediaName);                                
            }
            var media = _mediaService.GetMediaByFilename(mediaName);
            product.AddMedia(new ProductMedia
            {
                MediaId = media.Id,
                StormyProductId = product.Id,                
            });
            await _productService.UpdateProductAsync(product);
            return Ok(Result.Ok("Image created with success"));
        }
    }
}
