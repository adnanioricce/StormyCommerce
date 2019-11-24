using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Data.Stores;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TestHelperLibrary.Extensions;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class UserIdentityServiceTests
    {
        private readonly IUserIdentityService service;
        private readonly UserManager<StormyCustomer> _userManager;
        public UserIdentityServiceTests(IUserIdentityService identityService,
            UserManager<StormyCustomer> userManager)
        {
            service = identityService;
            _userManager = userManager;            
        }
        [Fact]
        public async Task CreateUserAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = new StormyCustomer { 
                Email = "example@email.com"
            };
            string password = "!D4vpassword";

            // Act
            var result = await service.CreateUserAsync(user,password);

            // Assert
            Assert.True(result.Succeeded);
        }

        [Fact]
        public async Task ConfirmEmailAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = null;
            string code = null;

            // Act
            var result = await service.ConfirmEmailAsync(user,code);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task ResetPasswordAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = null;
            string token = null;
            string newPassword = null;

            // Act
            var result = await service.ResetPasswordAsync(
                user,
                token,
                newPassword);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetUserByEmail_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string email = "adnangonzaga@gmail.com";

            // Act
            var user = service.GetUserByEmail(email);

            // Assert
            Assert.Equal(email,user.Email);
        }

        [Fact]
        public async Task GetUserByEmailAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string email = "adnangonzaga@gmail.com";

            // Act
            var user = await service.GetUserByEmailAsync(email);

            // Assert
            Assert.Equal(email,user.Email);
        }

        [Fact]
        public void GetUserByUsername_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string username = "stormydev";
            // Act
            var user = service.GetUserByUsername(username);
            // Assert
            Assert.Equal(username,user.UserName);
        }

        [Fact]
        public void GetUserById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string userId = _userManager.Users.First().Id;

            // Act
            var result = service.GetUserById(userId);

            // Assert
            Assert.Equal(userId,result.Id);
        }

        [Fact]
        public async Task GetUserByClaimPrincipal_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var customer = _userManager.GetTestCustomer();
            ClaimsPrincipal principal = IdentityTestUtils.GetClaimsPrincipal(customer);            
            // Act
            var result = await service.GetUserByClaimPrincipal(principal);

            // Assert   
            var userId = principal.Claims.FirstOrDefault(c => string.Equals(c.Value, result.Id, StringComparison.OrdinalIgnoreCase));
            var email = principal.Claims.FirstOrDefault(c => string.Equals(c.Value, result.Email, StringComparison.OrdinalIgnoreCase));
            var role = principal.Claims.First(c => string.Equals(c.Value, result.Role.Name, StringComparison.OrdinalIgnoreCase));
            Assert.NotNull(userId);
            Assert.NotNull(email);
            Assert.NotNull(role);            
        }

        [Fact]
        public void GetUserManager_StateUnderTest_ExpectedBehavior()
        {            
            // Act
            var result = service.GetUserManager();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<UserManager<StormyCustomer>>(result);
        }

        [Fact]
        public async Task PasswordSignInAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = _userManager.Users.FirstOrDefault(u => string.Equals(u.Email,"adnangonzaga@gmail.com", StringComparison.OrdinalIgnoreCase));
            string password = "!D4velopment";
            bool isPersistent = false;
            bool lockoutInFailure = false;

            // Act
            var result = await service.PasswordSignInAsync(user,password,isPersistent,lockoutInFailure);

            // Assert
            Assert.True(result.Succeeded);
        }

        [Fact]
        public async Task CreateEmailConfirmationCode_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = Seeders.StormyCustomerSeed().First();

            // Act
            var result = await service.CreateEmailConfirmationCode(user);

            // Assert            
            Assert.True(!string.IsNullOrEmpty(result));            
        }

        [Fact]
        public async Task EditUserAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer customer = _userManager.Users.First();
            customer.CPF = "123456789";
            customer.SecurityStamp = Guid.NewGuid().ToString();
            // Act
            var result = await service.EditUserAsync(customer);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public void VerifyHashPassword_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = _userManager.Users.FirstOrDefault(u => string.Equals(u.Email,"adnangonzaga@gmail.com", StringComparison.OrdinalIgnoreCase));
            string hashedPassword = user.PasswordHash;
            string providedPassword = "!D4velopment";
            // Act
            var result = service.VerifyHashPassword(user,hashedPassword,providedPassword);
            //Assert            
        }                
        [Fact]
        public void BuildClaims_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = _userManager.Users.FirstOrDefault(u => string.Equals(u.Email,"adnangonzaga@gmail.com", StringComparison.OrdinalIgnoreCase));
            // Act
            var result = service.BuildClaims(user);
            // Assert
            Assert.Equal(4,result.Count());
            Assert.Equal("Customer", result.FirstOrDefault(c => string.Equals(c.Value,user.Role.Name)).Value);
        }

        [Fact]
        public async Task GeneratePasswordResetTokenAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = _userManager.Users.FirstOrDefault(u => string.Equals(u.Email,"adnangonzaga@gmail.com", StringComparison.OrdinalIgnoreCase));
            // Act
            var result = await service.GeneratePasswordResetTokenAsync(user);
            // Assert
            Assert.IsType<string>(result);
            Assert.True(!string.IsNullOrEmpty(result));
        }

        [Fact]
        public async Task IsEmailConfirmedAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = _userManager.Users.First();
            // Act
            var result = await service.IsEmailConfirmedAsync(user);
            // Assert
            Assert.Equal(user.EmailConfirmed,result);
        }

        [Fact]
        public async Task AssignUserToRole_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyCustomer user = _userManager.Users.FirstOrDefault();
            string roleName = Roles.Customer;

            // Act
            var result = await service.AssignUserToRole(user,roleName);
            user = _userManager.Users.FirstOrDefault(u => string.Equals(u.Id,user.Id,StringComparison.OrdinalIgnoreCase));
            // Assert
            Assert.True(result.Success);
            Assert.Equal(user.Role.Name, roleName);
        }
    }
}
