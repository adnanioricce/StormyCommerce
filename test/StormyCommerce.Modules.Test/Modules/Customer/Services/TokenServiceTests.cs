using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using TestHelperLibrary.Extensions;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class TokenServiceTests
    {
        private readonly ITokenService service;
        private readonly UserManager<StormyCustomer> userManager;
        public TokenServiceTests(ITokenService _service, UserManager<StormyCustomer> userManager)
        {
            service = _service;
            this.userManager = userManager;
        }
        [Fact]
        public void GenerateAccessToken_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                      
            IEnumerable<Claim> claims = IdentityTestUtils.GetClaims(this.userManager.GetTestCustomer());

            // Act
            var result = service.GenerateAccessToken(claims);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result);
        }

        [Fact]
        public void GenerateRefreshToken_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            // Act
            var result = service.GenerateRefreshToken();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetPrincipalFromExpiredToken_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string token = service.GenerateAccessToken(IdentityTestUtils.GetClaims(this.userManager.GetTestCustomer()));

            // Act
            var result = service.GetPrincipalFromExpiredToken(token);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ClaimsPrincipal>(result);
        }
    }
}
