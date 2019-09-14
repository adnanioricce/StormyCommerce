using Microsoft.AspNetCore.Mvc;
using Moq;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Area.ViewModels;
using StormyCommerce.Module.Customer.Controllers;
using StormyCommerce.Module.Customer.Services;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TestHelperLibrary.Mocks;
using Xunit;

namespace Modules.Test.Customers
{
    public class AuthenticationControllerTest
    {
        private readonly ApplicationUser appUserSample;
        private readonly AuthenticationController _controller;

        private UserIdentityService GetUserIdentityService(FakeUserManager fakeUserManager)
        {
            return new UserIdentityService(new FakeSignInManager(), fakeUserManager, null);
        }

        public AuthenticationControllerTest()
        {
            var fakeTokenService = new Mock<ITokenService>();
            fakeTokenService
                .Setup(f => f.GenerateAccessToken(It.IsAny<IEnumerable<Claim>>()))
                .Returns(It.IsAny<string>());
            var fakeUserManager = new FakeUserManager();
            appUserSample = fakeUserManager.Users.FirstOrDefault();
            _controller = new AuthenticationController(
             GetUserIdentityService(fakeUserManager),
             fakeTokenService.Object,
             //TODO:Create fake Logger,CustomerService and mapper
             GetFakeEmailSender(),null,null,null);
        }

        private IEmailSender GetFakeEmailSender()
        {
            var fakeEmailSender = new Mock<IEmailSender>();
            fakeEmailSender
            .Setup(f => f.SendEmailAsync(It.IsAny<string>(),
            It.IsAny<string>(),
            It.IsAny<string>(),
            false));
            return fakeEmailSender.Object;
        }

        [Fact]
        public async Task LoginAsync_VmWithValidEmailAndPassword_ShouldReturnJWT()
        {
            //Arrange
            var loginVm = new SignInVm
            {
                Username = appUserSample.UserName,
                Email = appUserSample.Email,
                Password = "Ty22f@7#32!"
            };
            //Act
            var result = Assert.IsType<OkObjectResult>(await _controller.LoginAsync(loginVm));
            //Assert
            //How do I test it?
            Assert.Equal(200, result.StatusCode);
        }

        //TODO: Test this on the integration test, this don't cover what is needed
    }
}
