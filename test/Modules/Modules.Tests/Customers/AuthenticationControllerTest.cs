using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SimplCommerce.Module.Core.Services;
using SimplCommerce.Module.SampleData.Extensions;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Helpers;
using StormyCommerce.Module.Customer.Area.ViewModels;
using StormyCommerce.Module.Customer.Controllers;
using StormyCommerce.Module.Customer.Services;
using TestHelperLibrary.Mocks;
using Xunit;

namespace Modules.Test.Customers
{
    public class AuthenticationControllerTest
    {
        // private UserIdentityService GetUserIdentityService()
        // {
        //     return new UserIdentityService(new FakeSignInManager(),new FakeUserManager(),null); 
        // }
        // public AuthenticationController CreateController()
        // {
        //     var appUser = Seeders.ApplicationUserSeed().FirstOrDefault();
            
        //     //fakeIdentityService
        //     var fakeTokenService = new Mock<ITokenService>();            
        //     fakeTokenService
        //         .Setup(f => f.GenerateAccessToken(It.IsAny<IEnumerable<Claim>>()))
        //         .Returns(It.IsAny<string>());             
        //     //TODO:Create the EmailSender mock
        //     var controller = new AuthenticationController(GetUserIdentityService(), fakeTokenService.Object,null);
        //     return controller;
        // }
        // [Fact]
        // public async Task LoginAsync_VmWithValidEmailAndPassword_ShouldReturnJWT()
        // {
        //     //Arrange
	    //     var controller = CreateController();
	    //     var loginVm = new SignInVm
	    //     {
        //         Username = "someUser",
        //         Email = "myemail@example.com",
        //         Password = "!Tr27gh43"
	    //     };
        //     //Act
	    //     var result = (await controller.LoginAsync(loginVm)) as OkObjectResult;
        //     //Assert
        //     //How do I test it?
        //     Assert.NotNull(result);
        // }
        // [Fact]
        // public async Task RegisterAsync_ReceivedValidVm_ShouldReturnSuccessMessage()
        // {
        //     //Arrange
        //     var controller = CreateController();
        //     var registerVm = new SignUpVm
        //     {
        //         //TODO:research -> Why we need to Confirm password?
        //         Email = "myemail@example.com",
        //         Password = "!Tr27gh43"                
        //     }; 
        //     //Act 
        //     var result = (await controller.RegisterAsync(registerVm)) as OkObjectResult;             
        //     //Assert 
        //     Assert.NotNull(result);
        // }        
    }
}
