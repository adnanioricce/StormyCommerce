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
    public class FakeUserManager : UserManager<User>
    {
        private readonly IQueryable<User> _users;

        public FakeUserManager() : base(
            new Mock<IUserStore<User>>().Object,
            new Mock<IOptions<IdentityOptions>>().Object,
            new Mock<IPasswordHasher<User>>().Object,
            new[] { new Mock<IUserValidator<User>>().Object },
            new[] { new Mock<IPasswordValidator<User>>().Object },
            new Mock<ILookupNormalizer>().Object,
                  new Mock<IdentityErrorDescriber>().Object,
                  new Mock<IServiceProvider>().Object,
                  new Mock<ILogger<UserManager<User>>>().Object)
        {
            _users = StormyCommerce.Infraestructure.Extensions.IdentityDataSeed.ApplicationUserSeed(4).AsQueryable();
        }

        public override IQueryable<User> Users => _users;

        public override Task<IdentityResult> CreateAsync(User user, string password)
        {
            _users.Append(user);
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<IdentityResult> AddToRoleAsync(User user, string role)
        {
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<string> GenerateEmailConfirmationTokenAsync(User user)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }

        public override Task<User> FindByNameAsync(string userName)
        {
            return Task.FromResult(Users.FirstOrDefault(u => u.UserName == userName));
        }

        public override Task<string> GetEmailAsync(User user)
        {
            return Task.FromResult(user.Email);
        }

        public override Task<IList<string>> GetRolesAsync(User user)
        {
            return Task.FromResult((IList<string>)FakeRoles);
        }

        public override Task<User> FindByEmailAsync(string email)
        {
            return Task.FromResult(Users.First(u => u.Email == email));
        }

        private IList<string> FakeRoles => new List<string> { "admin" };
    }
}
