using Microsoft.AspNetCore.Identity;
using SimplCommerce.WebHost;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Services;
using System.Threading.Tasks;
using TestHelperLibrary;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class UserIdentityControllerTest : IClassFixture<CustomWebApplicationFactory>
    {
        //private readonly CustomWebApplicationFactory _factory;
        //public UserIdentityControllerTest(CustomWebApplicationFactory factory)
        //{
        //    _factory = factory;                        
        //    //_userIdentityService = new UserIdentityService(signInManager, userManager,null);
        //}
        //[Theory]
        //[InlineData("/api/")]
        //public async Task CreateUserAsync(string url)
        //{
        //    //Arrange 
            
        //    //Act 
            
        //    //Assert
        //    Assert.True(false);
        //}
    }
}
