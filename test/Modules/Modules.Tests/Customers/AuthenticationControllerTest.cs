using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SimplCommerce.Module.Core.Services;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Extensions;
using StormyCommerce.Infraestructure.Helpers;
using StormyCommerce.Module.Customer.Area.ViewModels;
using StormyCommerce.Module.Customer.Controllers;
using StormyCommerce.Module.Customer.Services;
using SimplCommerce.Module.EmailSenderSendgrid;
using TestHelperLibrary.Mocks;
using Xunit;
using Microsoft.Extensions.Configuration;

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
             GetFakeEmailSender());
        }        
        private EmailSender GetFakeEmailSender()
        {
            var fakeConfigSection = new Mock<IConfigurationSection>();
            fakeConfigSection.SetupGet(f => f[It.IsAny<string>()]).Returns("fake_result");
            // fakeConfigSection.SetupGet(f => f[It.Is<string>(s => s == "SendGrid:Email:ApiKey")])
            // .Returns("fakeKey");
            // fakeConfigSection.SetupGet(f => f[It.Is<string>()])
            var fakeConfiguration = new Mock<IConfiguration>();
            fakeConfiguration
                .Setup(f => f.GetValue(It.IsAny<string>(),It.IsAny<string>()))
                .Returns(Guid.NewGuid().ToString("N"));                                   
            var fakeEmailSender = new Mock<EmailSender>(fakeConfiguration.Object);                                                
            return fakeEmailSender.Object;
        }
        [Fact]
        public async Task LoginAsync_VmWithValidEmailAndPassword_ShouldReturnJWT()
        {
            //Arrange            
            var loginVm = new SignInVm
            {
                Username = "someUser",
                Email = "myemail@example.com",
                Password = "!Tr27gh43"
            };
            //Act
            var result = Assert.IsType<OkObjectResult>(await _controller.LoginAsync(loginVm));
            //Assert
            //How do I test it?
            Assert.Equal(200,result.StatusCode);            
        }
        [Fact]
        public async Task RegisterAsync_ReceivedValidVm_ShouldReturnSuccessMessage()
        {
            //Arrange            
            var signUpVm = new SignUpVm
            {
                //TODO:research -> Why we need to Confirm password?
                Email = "myemail@example.com",
                Password = "!Tr27gh43"
            };
            //Act 
            var result = Assert.IsAssignableFrom<OkObjectResult>(await _controller.RegisterAsync(signUpVm));
            //Assert 
            Assert.NotNull(result);
        }
    }
}
