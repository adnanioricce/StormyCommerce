using System;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Entities.User
{
    public class UserRole : IdentityUserRole<long>
    {
        public UserRole()
        {
            
        }
        public UserRole(Role role)
        {
            Role = role;
        }
        public override long UserId { get; set; }

        public virtual StormyUser User { get; set; }

        public override long RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
