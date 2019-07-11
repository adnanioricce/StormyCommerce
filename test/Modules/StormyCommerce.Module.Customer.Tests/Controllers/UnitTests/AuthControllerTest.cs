using SimplCommerce.WebHost;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Dtos;
using System.Threading.Tasks;
using TestHelperLibrary;
using Xunit;

namespace StormyCommerce.Module.Customer.Tests.Controllers.UnitTests
{
    public class AuthControllerTest : CustomWebApplicationFactory<Startup>
    {
        private IUserIdentityService _identityService;        
        public AuthControllerTest(IUserIdentityService identityService)
        {
            _identityService = identityService;
        }
        [Theory]
        [InlineData(null,null)]
        public async Task Should_RegisterUser_If_ValidInput_Async(RegisterUserDto user,string password)
        {

        }
        [Theory]
        [InlineData(null, null)]
        public async Task Should_LoginUser_If_CorrectCredentials_Async(RegisterUserDto user, string password)
        {

        }        
    }
}
