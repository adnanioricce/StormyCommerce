using Microsoft.Extensions.Configuration;
using Moq;
using SimplCommerce.Module.Correios.Interfaces;
using SimplCommerce.Module.Correios.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SimplCommerce.Module.Correios.Tests.Services
{
    public class CorreiosServiceTests
    {
        private MockRepository mockRepository;

        private Mock<ICalcPrecoPrazoWSSoap> mockCalcPrecoPrazoWSSoap;
        private Mock<IConfiguration> mockConfiguration;

        public CorreiosServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockCalcPrecoPrazoWSSoap = this.mockRepository.Create<ICalcPrecoPrazoWSSoap>();
            this.mockConfiguration = this.mockRepository.Create<IConfiguration>();
        }

        private CorreiosService CreateService()
        {
            return new CorreiosService(
                this.mockCalcPrecoPrazoWSSoap.Object,
                this.mockConfiguration.Object);
        }

        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            CalcPrecoPrazoModel model = null;

            // Act
            var result = await service.CalculateDeliveryPriceAndTime(
                model);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var service = this.CreateService();
            DeliveryCalculationRequest request = null;

            // Act
            var result = await service.CalculateDeliveryPriceAndTime(
                request);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
