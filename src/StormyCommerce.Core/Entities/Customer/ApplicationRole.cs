using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.Customer
{
    public class ApplicationRole : IdentityRole,IEntityWithBaseTypeId<string>
    {
        public ApplicationRole(string roleName) : base(roleName){}
        public ApplicationRole(){}        
    }
}
