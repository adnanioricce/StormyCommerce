using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.Customer
{
    public class ApplicationRole : IdentityRole<string>,IEntityWithBaseTypeId<string>
    {
        public ApplicationRole()
        {

        }
        public ApplicationRole(string roleName) : base(roleName)
        {

        }
        //public IList<UserRole> Users { get; set; } = new List<UserRole>
    }
}
