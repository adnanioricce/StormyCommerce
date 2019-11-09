using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Stores
{
    public class StormyUserStore : UserStore<StormyCustomer, ApplicationRole, StormyDbContext>
    {
        public StormyUserStore(StormyDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
