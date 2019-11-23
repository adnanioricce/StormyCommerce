﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Module.Catalog.Areas.Catalog.Controllers;
using StormyCommerce.Module.Catalog.Models;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Catalog
{
    public class _controllerTests : IDisposable
    {                
        private readonly MediaController _controller;
        public _controllerTests(IMediaService mediaService,IProductService productService)
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
                ImageName = "image-name",                
                ProductId = 1
            };

            // Act
            var result = (await _controller.AddProductImage(_model)) as OkObjectResult;

            // Assert
            Assert.Equal(200,(int)result.StatusCode);
        }
    }
}
