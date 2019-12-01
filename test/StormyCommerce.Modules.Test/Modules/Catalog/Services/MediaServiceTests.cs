using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Services.Catalog;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Services.Catalog
{
    public class MediaServiceTests
    {
        private readonly IMediaService service;
        public MediaServiceTests(IMediaService mediaService)
        {
            service = mediaService;
        }
        [Fact]
        public void GetMediaByFilename_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string fileName = null;

            // Act
            var result = service.GetMediaByFilename(fileName);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetMediaUrl_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Media media = null;

            // Act
            var result = service.GetMediaUrl(
                media);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetMediaUrl_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            string fileName = null;

            // Act
            var result = service.GetMediaUrl(
                fileName);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetThumbnailUrl_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Media media = null;

            // Act
            var result = service.GetThumbnailUrl(
                media);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SaveMediaAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Stream mediaBinaryStream = null;
            string fileName = null;
            string mimeType = null;

            // Act
            await service.SaveMediaAsync(mediaBinaryStream,fileName,mimeType);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteMediaAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Media media = null;

            // Act
            await service.DeleteMediaAsync(
                media);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteMediaAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            string fileName = null;

            // Act
            await service.DeleteMediaAsync(
                fileName);

            // Assert
            Assert.True(false);
        }
    }
}
