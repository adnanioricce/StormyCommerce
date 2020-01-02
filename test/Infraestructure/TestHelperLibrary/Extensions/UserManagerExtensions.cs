using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using TestHelperLibrary.Utils;

namespace TestHelperLibrary.Extensions
{
    public static class UserManagerExtensions
    {
        public static User GetTestCustomer(this UserManager<User> manager)
        {
            return manager.Users.FirstOrDefault(u => string.Equals(u.Email, "adnangonzaga@gmail.com", StringComparison.OrdinalIgnoreCase));
        }
        public static User GetCustomerForEditOperations(this UserManager<User> manager)
        {
            return manager.Users.FirstOrDefault(u => string.Equals(u.Email, "aguinobaldis@gmail.com", StringComparison.OrdinalIgnoreCase));
        }
        public static ControllerContext CreateTestContext(this UserManager<User> manager,User user)
        {
            var claimPrincipal = IdentityTestUtils.GetClaimsPrincipal(user);
            return new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = claimPrincipal,
                }
            };
        }
        public static ControllerContext CreateTestContext(this UserManager<User> manager)
        {
            var claimPrincipal = IdentityTestUtils.GetClaimsPrincipal(manager.GetTestCustomer());
            return new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = claimPrincipal,
                    
                    
                    
                }
            };
        }
    }
}
