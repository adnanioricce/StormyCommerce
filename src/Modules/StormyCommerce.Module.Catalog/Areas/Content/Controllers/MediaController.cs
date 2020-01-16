using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Web.Filters;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Services;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Catalog.Models.Requests;


namespace StormyCommerce.Module.Catalog.Areas.Content.Controllers
{
    [ApiController]
    [Authorize(Roles = "admin")]
    [Route("api/[Controller]")]
    public class MediaController : Controller
    {
        private readonly IMediaService _mediaService;
        private readonly IStormyProductService _productService;
        
        public MediaController(IMediaService mediaService, IStormyProductService productService)
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
            //TODO:Refactor
            var media = _mediaService.GetMediaUrl(mediaName);
            product.AddMedia(new ProductMedia
            {
                Media = new Media{
                    FileName = media
                },
                ProductId = product.Id,                
            });
            await _productService.UpdateProductAsync(product);
            return Ok(Result.Ok("Image created with success"));
        }
    }
}
