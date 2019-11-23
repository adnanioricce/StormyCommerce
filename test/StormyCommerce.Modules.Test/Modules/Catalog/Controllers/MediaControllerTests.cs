using Moq;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Module.Catalog.Areas.Catalog.Controllers;
using StormyCommerce.Module.Catalog.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Catalog
{
    public class MediaControllerTests : IDisposable
    {
        private MockRepository mockRepository;

        private Mock<IMediaService> mockMediaService;
        private Mock<IProductService> mockProductService;

        public MediaControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockMediaService = this.mockRepository.Create<IMediaService>();
            this.mockProductService = this.mockRepository.Create<IProductService>();
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private MediaController CreateMediaController()
        {
            return new MediaController(
                this.mockMediaService.Object,
                this.mockProductService.Object);
        }

        [Fact]
        public async Task UploadMediaFile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mediaController = this.CreateMediaController();
            CreateImageRequest model = null;

            // Act
            var result = await mediaController.UploadMediaFile(
                model);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddProductImage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mediaController = this.CreateMediaController();
            CreateProductImageRequest _model = null;

            // Act
            var result = await mediaController.AddProductImage(
                _model);

            // Assert
            Assert.True(false);
        }
    }
}
