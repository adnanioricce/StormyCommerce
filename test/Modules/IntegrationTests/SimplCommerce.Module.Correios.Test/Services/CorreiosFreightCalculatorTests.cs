using Moq;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Correios.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SimplCommerce.Module.Correios.Tests.Services
{
    public class CorreiosFreightCalculatorTests
    {
        private MockRepository mockRepository;

        private Mock<CorreiosService> mockCorreiosService;
        private Mock<IRepository<Cart>> mockRepository;

        public CorreiosFreightCalculatorTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockCorreiosService = this.mockRepository.Create<CorreiosService>();
            this.mockRepository = this.mockRepository.Create<IRepository<Cart>>();
        }

        private CorreiosFreightCalculator CreateCorreiosFreightCalculator()
        {
            return new CorreiosFreightCalculator(
                this.mockCorreiosService.Object,
                this.mockRepository.Object);
        }

        [Fact]
        public async Task CalculateFreightForItem_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var correiosFreightCalculator = this.CreateCorreiosFreightCalculator();
            CalculateItemFreightRequest request = null;

            // Act
            var result = await correiosFreightCalculator.CalculateFreightForItem(
                request);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CalculateFreightForPackage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var correiosFreightCalculator = this.CreateCorreiosFreightCalculator();
            CalculatePackageFreightRequest request = null;

            // Act
            var result = await correiosFreightCalculator.CalculateFreightForPackage(
                request);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
