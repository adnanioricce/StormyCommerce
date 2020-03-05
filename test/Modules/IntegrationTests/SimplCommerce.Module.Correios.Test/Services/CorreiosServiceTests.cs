using Microsoft.Extensions.Configuration;
using Moq;
using SimplCommerce.Module.Correios.Interfaces;
using SimplCommerce.Module.Correios.Models;
using SimplCommerce.Module.Correios.Models.Requests;
using SimplCommerce.Module.Correios.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SimplCommerce.Module.Correios.Tests.Services
{
    public class CorreiosServiceTests
    {
        private readonly CorreioService _service;
        public CorreiosServiceTests(CorreiosService service)
        {
            _service = service;
        }                

        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            CalcPrecoPrazoModel model = null;

            // Act
            var result = await _service.CalculateDeliveryPriceAndTime(
                model);

            // Assert
            Assert.True(false);           
        }

        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            DeliveryCalculationRequest request = null;

            // Act
            var result = await _service.CalculateDeliveryPriceAndTime(
                request);

            // Assert
            Assert.True(false);            
        }
    }
}
