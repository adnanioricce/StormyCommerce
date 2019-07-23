using Microsoft.AspNetCore.Identity;
using SimplCommerce.WebHost;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Infraestructure.Services.Authentication;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class UserIdentityControllerTest : IClassFixture<TestFixture<Startup>>
    {
        private readonly IUserIdentityService _userIdentityService;
        public UserIdentityControllerTest(TestFixture<Startup> testFixture)
        {
            var signInManager = (SignInManager<ApplicationUser>)testFixture.Server.Host.Services.GetService(typeof(SignInManager<ApplicationUser>));
            var userManager = (UserManager<ApplicationUser>)testFixture.Server.Host.Services.GetService(typeof(UserManager<ApplicationUser>));
            _userIdentityService = new UserIdentityService(signInManager, userManager);
        }
        [Theory]
        [InlineData("sample@email.com", "adnanioricce", "SAMPLE@EMAIL.COM", true, "Ty22f@7#32!")]
        public async Task CreateUserAsync(string email,string userName,string normalizedEmail,bool emailConfirmed,string password)
        {
            //Arrange 
            var appUser = new ApplicationUser
            {
                Email = email,
                UserName = userName,
                NormalizedEmail = normalizedEmail,
                EmailConfirmed = emailConfirmed,
            };
            //Act 
            var result = await _userIdentityService.CreateUserAsync(appUser, password);
            //Assert
            Assert.True(result.Succeeded);
        }

    }
}
