using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.Core.Extensions
{
    public class SimplRoleStore: RoleStore<Role, StormyDbContext, long, UserRole, IdentityRoleClaim<long>>
    {
        public SimplRoleStore(StormyDbContext context) : base(context)
        {
        }
    }
}
