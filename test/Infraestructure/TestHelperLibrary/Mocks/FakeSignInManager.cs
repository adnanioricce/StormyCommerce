using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using StormyCommerce.Infraestructure.Entities;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestHelperLibrary.Mocks
{
    public class FakeSignInManager : SignInManager<ApplicationUser>
    {
        private readonly HttpContextAccessor _httpAccessor;
        public FakeSignInManager()
        : base(
            new Mock<FakeUserManager>().Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>().Object,
            new Mock<IOptions<IdentityOptions>>().Object,
            new Mock<ILogger<SignInManager<ApplicationUser>>>().Object,
            new Mock<IAuthenticationSchemeProvider>().Object
        )
        {
            _httpAccessor = new HttpContextAccessor();
            _httpAccessor.HttpContext.User = new System.Security.Claims.ClaimsPrincipal(new ClaimsIdentity[]{
                new ClaimsIdentity(new Claim[]{
                    new Claim("sub","guest@email.com"),
                    new Claim("id","asdf1234")
                })
            });
        }

        public override Task<SignInResult> PasswordSignInAsync(ApplicationUser user, string password, bool isPersistent, bool lockoutOnFailure)
        {
            return Task.FromResult(SignInResult.Success);
        }
    }
}
