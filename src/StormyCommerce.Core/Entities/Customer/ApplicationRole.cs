using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.Customer
{
    public class ApplicationRole : IdentityRole,IEntityBaseWithTypedId<string>
    {
        public ApplicationRole(string roleName) : base(roleName){}
        public ApplicationRole(){}        
    }
}
