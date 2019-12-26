using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.User
{
    public class Role : IdentityRole<long>, IEntityBaseWithTypedId<long>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
