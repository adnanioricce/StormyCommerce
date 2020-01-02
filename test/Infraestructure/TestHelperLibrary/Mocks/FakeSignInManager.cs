using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestHelperLibrary.Mocks
{
    public class FakeSignInManager : SignInManager<User>
    {
        private readonly HttpContextAccessor _httpAccessor;
        public FakeSignInManager()
        : base(
            new Mock<FakeUserManager>().Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<User>>().Object,
            new Mock<IOptions<IdentityOptions>>().Object,
            new Mock<ILogger<SignInManager<User>>>().Object,
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

        public override Task<SignInResult> PasswordSignInAsync(User user, string password, bool isPersistent, bool lockoutOnFailure)
        {
            return Task.FromResult(SignInResult.Success);
        }
    }
}
