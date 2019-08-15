using System;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Module.Customers.Area.Controllers;
namespace Modules.Test.Customers
{
    public class AuthenticationControllerTest
    {
        public AuthenticationController CreateController()
        {     
	        var fakeIdentityService = new Mock<UserIdentityService>();
            
            fakeIdentityService
                .Setup(f => f.GetUserByEmail(It.Any<string>()))
                .Returns("myemail@example.com");
            fakeIdentityService
                //maybe this don't work,if the password policies is beign applied
                .Setup(f => f.PasswordSignInAsync(It.Any<ApplicationUser>(),It.Any<string>()));                
                //Return? 
            fakeIdentityService
            var fakeTokenService = new Mock<ITokenService>();            
            fakeTokenService
                .Setup(f => f.GenerateAccessToken(It.Any<IEnumerable<Claims>>()))
                .Returns(It.Any<string>());             
            //TODO:Create the EmailSender mock
            var controller = new AuthenticationController(fakeIdentityService,null,fakeTokenService);
            return controller;
        }
        [Fact]
        public async Task LoginAsync_VmWithValidEmailAndPassword_ShouldReturnJWT()
        {
            //Arrange
	        var controller = CreateController();
	        var loginVm = new SignInVm
	        {
                Username = "someUser",
                Email = "myemail@example.com",
                Password = "!Tr27gh43"
	        };
            //Act
	        var result = controller.LoginAsync(loginVm);
            //Assert
            Assert.True(!string.IsNullOrEmpty(result));
        }
        [Fact]
        public async Task RegisterAsync_ReceivedValidVm_ShouldReturnSuccessMessage()
        {
            //Arrange
            var controller = CreateController(); 
            var registerVm = new SignUpVm{
                //TODO:research -> Why we need to Confirm password?
                Email = "myemail@example.com",
                Password = "!Tr27gh43",
                ConfirmPassword = "!Tr27gh43"
            } 
            //Act 
            var result = controller.RegisterAsync(registerVm);             
            //Assert 
            Assert.True(false);
        }        
    }
}
