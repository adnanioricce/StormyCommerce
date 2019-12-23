using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Moq;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Module.Catalog.Areas.Catalog.Controllers;
using StormyCommerce.Module.Catalog.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Catalog
{
    public class MediaControllerTests : IDisposable
    {                
        private readonly MediaController _controller;
        public MediaControllerTests(IMediaService mediaService,IProductService productService)
        {
            _controller = new MediaController(mediaService, productService);
        }

        public void Dispose()
        {
            _controller.Dispose();
        }        

        [Fact]
        public async Task UploadMediaFile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange           
            CreateImageRequest model = new CreateImageRequest
            {                
                Filename = "image.jpg"
            };

            // Act
            var response = await _controller.UploadMediaFile(model);
            var result = response as OkObjectResult;
            // Assert
            Assert.Equal(200,(int)result.StatusCode);            
        }

        [Fact]
        public async Task AddProductImage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            CreateProductImageRequest _model = new CreateProductImageRequest { 
                ImageName = "Logo_StormyCommerce.jpeg",                
                ProductId = 1,               
            };
            using (var stream = new FileStream(_model.ImageName,FileMode.Create))
            {
                _model.File = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(_model.ImageName)) { 
                    Headers = new HeaderDictionary(),
                    ContentType = "image/png"
                };
            }            
            // Act
            var result = (await _controller.AddProductImage(_model)) as ObjectResult;

            // Assert
            Assert.Equal(200,(int)result.StatusCode);
        }
    }
}
