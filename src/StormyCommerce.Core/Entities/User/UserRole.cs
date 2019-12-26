using System;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Entities.User
{
    public class UserRole : IdentityUserRole<long>
    {
        public override long UserId { get; set; }

        public StormyCustomer User { get; set; }

        public override long RoleId { get; set; }

        public Role Role { get; set; }
    }
}
