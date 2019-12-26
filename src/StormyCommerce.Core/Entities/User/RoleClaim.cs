using System;
using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.User
{
    public class RoleClaim : IdentityRoleClaim<long>
    {              
        public virtual Role Role { get; set; }   
    }
}
