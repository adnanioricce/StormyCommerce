using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Correios.Services;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Models.Requests;
using SimplCommerce.Module.ShoppingCart.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SimplCommerce.Module.Correios.UnitTests.Services
{
    public class CorreiosFreightCalculatorTests
    {
        [Fact]
        public async Task CalculateFreightForItem_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var correiosFreightCalculator = new CorreiosFreightCalculator(null,null);
            CalculateItemFreightRequest request = null;

            // Act
            var result = await correiosFreightCalculator.CalculateFreightForItem(
                request);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CalculateFreightForPackage_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var correiosFreightCalculator = new CorreiosFreightCalculator(null, null);
            CalculatePackageFreightRequest request = null;

            // Act
            var result = await correiosFreightCalculator.CalculateFreightForPackage(
                request);

            // Assert
            Assert.True(false);
        }
    }
}
