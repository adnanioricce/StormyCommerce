using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using StormyCommerce.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Tests.Mocks
{
    public class FakeUserManager : UserManager<ApplicationUser>
    {
        public FakeUserManager() : base(
            new Mock<IUserStore<ApplicationUser>>().Object,
            new Mock<IOptions<IdentityOptions>>().Object,
            new Mock<IPasswordHasher<ApplicationUser>>().Object,
            new[] { new Mock<IUserValidator<ApplicationUser>>().Object },
            new[] { new Mock<IPasswordValidator<ApplicationUser>>().Object },
            new Mock<ILookupNormalizer>().Object,
                  new Mock<IdentityErrorDescriber>().Object,
                  new Mock<IServiceProvider>().Object,
                  new Mock<ILogger<UserManager<ApplicationUser>>>().Object)
        {           
        }        
        public override IQueryable<ApplicationUser> Users => base.Users.AsQueryable();
        public override Task<IdentityResult> CreateAsync(ApplicationUser user, string password)
        {
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<IdentityResult> AddToRoleAsync(ApplicationUser user, string role)
        {
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }
    }
}
