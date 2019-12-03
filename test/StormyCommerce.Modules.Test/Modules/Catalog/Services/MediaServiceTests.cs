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
        private readonly IStormyRepository<Media> _mediaRepository;
        public MediaServiceTests(IMediaService mediaService, IStormyRepository<Media> mediaRepository)
        {
            service = mediaService;
            _mediaRepository = mediaRepository;
        }
        [Fact,TestPriority(-1)]
        public void GetMediaByFilename_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string fileName = "filename.png";

            // Act
            var result = service.GetMediaByFilename(fileName);

            // Assert
            Assert.Equal(fileName,result.FileName);
        }

        [Fact]
        public async Task GetMediaUrl_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Media media = await _mediaRepository.GetByIdAsync(1);

            // Act
            var result = service.GetMediaUrl(media);

            // Assert
            Assert.True(!string.IsNullOrEmpty(result));
        }

        [Fact]
        public async Task GetMediaUrl_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange        
            var media = await _mediaRepository.GetByIdAsync(1);
            string fileName = media.FileName;

            // Act
            var result = service.GetMediaUrl(fileName);

            // Assert
            Assert.Contains(result,media.FileName);            
        }

        [Fact]
        public async Task GetThumbnailUrl_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Media media = await _mediaRepository.GetByIdAsync(1);

            // Act
            var result = service.GetThumbnailUrl(media);

            // Assert
            Assert.Contains(result,media.FileName);
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
            Media media = await _mediaRepository.GetByIdAsync(1);

            // Act
            await service.DeleteMediaAsync(media);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteMediaAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange        
            var media = await _mediaRepository.GetByIdAsync(1);
            string fileName = media.FileName;

            // Act
            await service.DeleteMediaAsync(fileName);

            // Assert
            Assert.True(media.IsDeleted);
        }
    }
}
