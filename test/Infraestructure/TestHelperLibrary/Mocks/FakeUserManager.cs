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
    public class FakeUserManager : UserManager<StormyCustomer>
    {
        private readonly IQueryable<StormyCustomer> _users;

        public FakeUserManager() : base(
            new Mock<IUserStore<StormyCustomer>>().Object,
            new Mock<IOptions<IdentityOptions>>().Object,
            new Mock<IPasswordHasher<StormyCustomer>>().Object,
            new[] { new Mock<IUserValidator<StormyCustomer>>().Object },
            new[] { new Mock<IPasswordValidator<StormyCustomer>>().Object },
            new Mock<ILookupNormalizer>().Object,
                  new Mock<IdentityErrorDescriber>().Object,
                  new Mock<IServiceProvider>().Object,
                  new Mock<ILogger<UserManager<StormyCustomer>>>().Object)
        {
            _users = StormyCommerce.Infraestructure.Extensions.IdentityDataSeed.ApplicationUserSeed(4).AsQueryable();
        }

        public override IQueryable<StormyCustomer> Users => _users;

        public override Task<IdentityResult> CreateAsync(StormyCustomer user, string password)
        {
            _users.Append(user);
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<IdentityResult> AddToRoleAsync(StormyCustomer user, string role)
        {
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<string> GenerateEmailConfirmationTokenAsync(StormyCustomer user)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }

        public override Task<StormyCustomer> FindByNameAsync(string userName)
        {
            return Task.FromResult(Users.FirstOrDefault(u => u.UserName == userName));
        }

        public override Task<string> GetEmailAsync(StormyCustomer user)
        {
            return Task.FromResult(user.Email);
        }

        public override Task<IList<string>> GetRolesAsync(StormyCustomer user)
        {
            return Task.FromResult((IList<string>)FakeRoles);
        }

        public override Task<StormyCustomer> FindByEmailAsync(string email)
        {
            return Task.FromResult(Users.First(u => u.Email == email));
        }

        private IList<string> FakeRoles => new List<string> { "admin" };
    }
}
