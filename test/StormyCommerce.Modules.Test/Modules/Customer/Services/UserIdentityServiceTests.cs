using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Data.Stores;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Customer
{
    public class UserIdentityServiceTests
    {
        [Fact]
        public async Task CreateUserAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;
            string password = null;

            // Act
            var result = await service.CreateUserAsync(
                user,
                password);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task ConfirmEmailAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;
            string code = null;

            // Act
            var result = await service.ConfirmEmailAsync(
                user,
                code);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task ResetPasswordAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
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
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            string email = null;

            // Act
            var result = service.GetUserByEmail(
                email);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetUserByEmailAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            string email = null;

            // Act
            var result = await service.GetUserByEmailAsync(
                email);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetUserByUsername_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            string username = null;

            // Act
            var result = service.GetUserByUsername(
                username);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetUserById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            string userId = null;

            // Act
            var result = service.GetUserById(
                userId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetUserByClaimPrincipal_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            ClaimsPrincipal principal = null;

            // Act
            var result = await service.GetUserByClaimPrincipal(
                principal);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetUserManager_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);

            // Act
            var result = service.GetUserManager();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task PasswordSignInAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;
            string password = null;
            bool isPersistent = false;
            bool lockoutInFailure = false;

            // Act
            var result = await service.PasswordSignInAsync(
                user,
                password,
                isPersistent,
                lockoutInFailure);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CreateEmailConfirmationCode_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;

            // Act
            var result = await service.CreateEmailConfirmationCode(
                user);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task EditUserAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer customer = null;

            // Act
            var result = await service.EditUserAsync(
                customer);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void VerifyHashPassword_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;
            string hashedPassword = null;
            string providedPassword = null;

            // Act
            var result = service.VerifyHashPassword(
                user,
                hashedPassword,
                providedPassword);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void HashPassword_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;
            string password = null;

            // Act
            var result = service.HashPassword(
                user,
                password);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SignOutAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);

            // Act
            await service.SignOutAsync();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void BuildClaims_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;

            // Act
            var result = service.BuildClaims(
                user);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GeneratePasswordResetTokenAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;

            // Act
            var result = await service.GeneratePasswordResetTokenAsync(
                user);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task IsEmailConfirmedAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;

            // Act
            var result = await service.IsEmailConfirmedAsync(
                user);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AssignUserToRole_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new UserIdentityService(TODO, TODO, TODO, TODO);
            StormyCustomer user = null;
            string roleName = null;

            // Act
            var result = await service.AssignUserToRole(
                user,
                roleName);

            // Assert
            Assert.True(false);
        }
    }
}
