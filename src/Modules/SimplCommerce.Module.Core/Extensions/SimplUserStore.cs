using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.Core.Extensions
{
    public class SimplUserStore : UserStore<User, Role, StormyDbContext, long, IdentityUserClaim<long>, UserRole,
        IdentityUserLogin<long>,IdentityUserToken<long>, IdentityRoleClaim<long>>
    {
        public SimplUserStore(StormyDbContext context, IdentityErrorDescriber describer) : base(context, describer)
        {
        }
    }
}
