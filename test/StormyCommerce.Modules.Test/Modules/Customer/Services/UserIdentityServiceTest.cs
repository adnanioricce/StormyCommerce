using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Extensions;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Mocks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Customer
{
    public class UserIdentityServiceTest
    {
        public IUserIdentityService Service { get; set; }
        private readonly FakeUserManager _fakeUserManager;
        private readonly StormyCustomer _sampleAppUser = IdentityDataSeed.ApplicationUserSeed().FirstOrDefault();

        public UserIdentityServiceTest()
        {
            _fakeUserManager = new FakeUserManager();
            var fakeSigninManager = new FakeSignInManager();
            Service = new UserIdentityService(fakeSigninManager, _fakeUserManager,null,null);
        }

        [Fact]
        public async Task CreateUserAsync_ValidUserNameAndPassword_ShouldCreateUserWithSuccess()
        {
            //Arrange
            var user = IdentityDataSeed.ApplicationUserSeed(1).FirstOrDefault();
            user.PasswordHash = "";
            //Act
            var result = await Service.CreateUserAsync(user, "Ty22f@7#32!");
            //Assert
            Assert.True(result.Succeeded);
        }

        [Fact]
        public async Task CreateUserAsync_InvalidUsernameAndPassword_ShouldReturnError()
        {
            //Arrange
            var user = new StormyCustomer { UserName = null, Email = null };
            //Act & Assert
            var result = await Assert.ThrowsAsync<ArgumentNullException>(async () => await Service.CreateUserAsync(user, null));
        }

        [Fact]
        public void GetByEmail_ExistingEmail_ShouldReturnApplicationUser()
        {
            //Arrange
            var user = _fakeUserManager.Users.First();
            //Act
            var retrievedUser = Service.GetUserByEmail(user.Email);
            //Assert
            Assert.Equal(user.UserName, retrievedUser.UserName);
            Assert.Equal(user.Email, retrievedUser.Email);
        }

        [Fact]
        public async Task PasswordSignIn_ValidInputAndExistingUser_ShouldReturnTrue()
        {
            //Arrange
            var user = _fakeUserManager.Users.First();
            //Act
            var result = await Service.PasswordSignInAsync(user, "Ty22f@7#32!", true, true);
            //Assert
            Assert.True(result.Succeeded);
        }

        [Fact]
        public async Task CreateEmailVerificationCode_UserSignUpSucceededEmailNotConfirmed_CreateEmailConfirmationLink()
        {
            //Arrange
            var user = _fakeUserManager.Users.First();
            //Act
            var result = await Service.CreateEmailConfirmationCode(user);
            //Assert
            Assert.NotNull(result);
        }
    }
}
