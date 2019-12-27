using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using StormyCommerce.Core.Entities.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestHelperLibrary.Mocks
{
    public class FakeUserManager : UserManager<StormyUser>
    {
        private readonly IQueryable<StormyUser> _users;

        public FakeUserManager() : base(
            new Mock<IUserStore<StormyUser>>().Object,
            new Mock<IOptions<IdentityOptions>>().Object,
            new Mock<IPasswordHasher<StormyUser>>().Object,
            new[] { new Mock<IUserValidator<StormyUser>>().Object },
            new[] { new Mock<IPasswordValidator<StormyUser>>().Object },
            new Mock<ILookupNormalizer>().Object,
                  new Mock<IdentityErrorDescriber>().Object,
                  new Mock<IServiceProvider>().Object,
                  new Mock<ILogger<UserManager<StormyUser>>>().Object)
        {
            _users = StormyCommerce.Infraestructure.Extensions.IdentityDataSeed.ApplicationUserSeed(4).AsQueryable();
        }

        public override IQueryable<StormyUser> Users => _users;

        public override Task<IdentityResult> CreateAsync(StormyUser user, string password)
        {
            _users.Append(user);
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<IdentityResult> AddToRoleAsync(StormyUser user, string role)
        {
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<string> GenerateEmailConfirmationTokenAsync(StormyUser user)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }

        public override Task<StormyUser> FindByNameAsync(string userName)
        {
            return Task.FromResult(Users.FirstOrDefault(u => u.UserName == userName));
        }

        public override Task<string> GetEmailAsync(StormyUser user)
        {
            return Task.FromResult(user.Email);
        }

        public override Task<IList<string>> GetRolesAsync(StormyUser user)
        {
            return Task.FromResult((IList<string>)FakeRoles);
        }

        public override Task<StormyUser> FindByEmailAsync(string email)
        {
            return Task.FromResult(Users.First(u => u.Email == email));
        }

        private IList<string> FakeRoles => new List<string> { "admin" };
    }
}
