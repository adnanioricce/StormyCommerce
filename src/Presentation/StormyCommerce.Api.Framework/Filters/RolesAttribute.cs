using System;
using Microsoft.AspNetCore.Authorization;

namespace StormyCommerce.Api.Framework.Filters
{
    public class RolesAttribute : AuthorizeAttribute
    {            
        public RolesAttribute(params string[] roles)
        {
            Roles = String.Join(",", roles);
        }
    }
}
