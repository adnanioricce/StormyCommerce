using Microsoft.Extensions.Configuration;
using StormyCommerce.Module.Customer.Services;
using System;
using Xunit;

namespace StormyCommerce.Modules.Tests.Customer
{
    public class TokenServiceTests
    {
        [Fact]
        public void GenerateAccessToken_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new TokenService(TODO);
            IEnumerable claims = null;

            // Act
            var result = service.GenerateAccessToken(
                claims);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GenerateRefreshToken_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new TokenService(TODO);

            // Act
            var result = service.GenerateRefreshToken();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetPrincipalFromExpiredToken_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new TokenService(TODO);
            string token = null;

            // Act
            var result = service.GetPrincipalFromExpiredToken(
                token);

            // Assert
            Assert.True(false);
        }
    }
}
