using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.User;

namespace StormyCommerce.Infraestructure.Data.Stores
{
    public class StormyUserStore : UserStore<User, Role, StormyDbContext, long, IdentityUserClaim<long>, UserRole,
        IdentityUserLogin<long>, IdentityUserToken<long>, IdentityRoleClaim<long>>
    {
        public StormyUserStore(StormyDbContext context, IdentityErrorDescriber describer) : base(context, describer)
        {
        }
    }
}
