﻿using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Interfaces
{
    public interface IUserIdentityService
    {
        Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password);        
        ApplicationUser GetUserByEmail(string email);
        Task<SignInResult> PasswordSignInAsync(ApplicationUser user,string password, bool isPersistent = true, bool lockoutInFailure = false);
        UserManager<ApplicationUser> GetUserManager();
        //Actually, you will not signout, it's a JWT based authentication
        Task SignOutAsync();
        Task<IEnumerable<Claim>> BuildClaims(ApplicationUser user);
        Task<string> CreateEmailConfirmationCode(ApplicationUser user);        

    }
}
