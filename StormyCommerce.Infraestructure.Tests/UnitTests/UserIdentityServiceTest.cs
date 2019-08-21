using Microsoft.AspNetCore.Identity;
using Moq;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Infraestructure.Repositories;
using StormyCommerce.Infraestructure.Services.Authentication;
using StormyCommerce.Infraestructure.Tests.Mocks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Infraestructure.Tests.UnitTests
{
    public class UserIdentityServiceTest
    {
        public IUserIdentityService Service { get; set; }          
        public UserIdentityServiceTest()
        {            
            var fakeUserManager = new FakeUserManager();
            var fakeSigninManager = new FakeSignInManager();            
            Service = new UserIdentityService(fakeSigninManager,new UserIdentityRepository(fakeUserManager));
        }
        [Fact]        
        public async Task CreateUserAsync_ValidUserNameAndPassword_ShouldCreateUserWithSuccess()
        {                      
           //Arrange            
           var user = new ApplicationUser { UserName = "a simple user",Email = "simpleEmail@email.com" };
           //Act 
           var result = await Service.CreateUserAsync(user, "Ty22f@7#32!");
           //Assert
           Assert.True(result.Succeeded);            
        }
        [Fact]
        public async Task CreateUserAsync_InvalidUsernameAndPassword_ShouldReturnError()
        {
            //Arrange
            var user = new ApplicationUser { UserName = null, Email = null };
            //Act
            var result = await Service.CreateUserAsync(user, null);
            //Assert           
            Assert.False(result.Succeeded);
        }
        [Fact]
        public void GetByEmail_ExistingEmail_ShouldReturnApplicationUser()
        {
            //Arrange
            var username = "adnanioricce";
            var email = "sample@email.com";
            //Act
            var user = Service.GetUserByEmail(email);
            //Assert
            Assert.Equal(username, user.UserName);
            Assert.Equal(email,user.Email);
        }
        [Fact]
        public async Task PasswordSignIn_ValidInputAndExistingUser_ShouldReturnTrue()
        {
            //Arrange 
            var user = new ApplicationUser { UserName = "adnanioricce", Email = "sample@email.com" };
            //Act
            var result = await Service.PasswordSignInAsync(user, "Ty22f@7#32!", true, true);
            //Assert 
            Assert.True(result.Succeeded);
        }
        [Fact]
        public async Task CreateEmailVerificationCode_UserSignUpSucceededEmailNotConfirmed_CreateEmailConfirmationLink()
        {
            //Arrange
            var user = new ApplicationUser { UserName = "adnanioricce", Email = "sample@email.com" };
            //Act
            var result = await Service.CreateEmailVerificationCode(user,user.Email);
            //Assert
            Assert.NotNull(result);

        }
    }
}
