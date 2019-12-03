﻿
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Data.Stores;
using StormyCommerce.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Services
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly SignInManager<StormyCustomer> _signInManager;
        private readonly UserManager<StormyCustomer> _userManager;       
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly StormyUserStore _userStore;        
        public UserIdentityService(SignInManager<StormyCustomer> signInManager,
            UserManager<StormyCustomer> identityRepository,
            RoleManager<ApplicationRole> roleManager,
            StormyUserStore userStore)
        {
            _signInManager = signInManager;
            _userManager = identityRepository;     
            _roleManager = roleManager;
            _userStore = userStore;
            _userManager.Users                
                .Include(u => u.CustomerWishlist)
                    .ThenInclude(u => u.WishlistItems)
                        .ThenInclude(u => u.Product)
                .Include(u => u.CustomerReviews)                    
                .Include(u => u.Addresses)       
                .Load();
            _roleManager.Roles.Load();            
        }

        public async Task<IdentityResult> CreateUserAsync(StormyCustomer user, string password)
        {
            if (user == null || password == null)
            {
                throw new ArgumentNullException("was not possible to create user, the given arguments was null");
            }
            if(string.IsNullOrEmpty(user.UserName) || string.IsNullOrWhiteSpace(user.UserName))
            {
                user.UserName = user.Email.Substring(0, user.Email.IndexOf("@"));
            }
            var result = await _userManager.CreateAsync(user, password);
            if (result == null)
            {
                throw new ArgumentNullException($"was not possible to create user,result is null {result}, on {nameof(CreateUserAsync)}");
            }
            if (result.Errors.Any())
            {
                var errorMessage = CreateErrorMessage(result);
                result.Errors.ToList().ForEach(error => Console.WriteLine($"Error creating user: code:{error.Code},{error.Description}"));
            }
            if (!result.Succeeded)
            {
                //TODO:Throw a error?
                return result;
            }
            return result;
        }
        
        public Task<IdentityResult> ConfirmEmailAsync(StormyCustomer user,string code)
        {
            return _userManager.ConfirmEmailAsync(user,code);
        }
        public Task<IdentityResult> ResetPasswordAsync(StormyCustomer user,string token,string newPassword)
        {
            return _userManager.ResetPasswordAsync(user,token,newPassword);
        }
        public StormyCustomer GetUserByEmail(string email)
        {           
            return _userManager.Users
                .FirstOrDefault(u => u.Email == email);
        }
        public async Task<StormyCustomer> GetUserByEmailAsync(string email)
        {
            return await _userManager.Users.Include(u => u.CustomerWishlist)
                    .ThenInclude(u => u.WishlistItems)
                        .ThenInclude(w => w.Product)
                .Include(u => u.CustomerReviews)
                    .ThenInclude(u => u.Product)
                .Include(u => u.Addresses)                    
                .FirstOrDefaultAsync(u => string.Equals(u.Email, email,StringComparison.OrdinalIgnoreCase)).ConfigureAwait(true);
        }
        public StormyCustomer GetUserByUsername(string username)
        {
            return _userManager.Users.FirstOrDefault(u => string.Equals(u.UserName,username,StringComparison.OrdinalIgnoreCase));
        }
        public StormyCustomer GetUserById(string userId)
        {            
            return _userManager.Users.First(u => string.Equals(u.Id, userId,StringComparison.OrdinalIgnoreCase));
        }
        public Task<StormyCustomer> GetUserByClaimPrincipal(ClaimsPrincipal principal)
        {            
            var email = principal.Claims.FirstOrDefault(c => c.Type.Contains("emailaddress"))?.Value ?? principal.FindFirstValue(JwtRegisteredClaimNames.Email);
            return GetUserByEmailAsync(email);
        }
        public UserManager<StormyCustomer> GetUserManager() => _userManager;

        public Task<SignInResult> PasswordSignInAsync(StormyCustomer user, string password, bool isPersistent = true, bool lockoutInFailure = false)
        {
            return _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutInFailure);
        }

        public Task<string> CreateEmailConfirmationCode(StormyCustomer user)
        {
            return _userManager.GenerateEmailConfirmationTokenAsync(user);
        }
        public async Task<Result> EditUserAsync(StormyCustomer customer)
        {
            var identityResult = await _userManager.UpdateAsync(customer).ConfigureAwait(true);
            if (identityResult.Errors.Any())
            {
                return CreateErrorMessage(identityResult);
            }
            return Result.Ok();
        }
        public PasswordVerificationResult VerifyHashPassword(StormyCustomer user,string hashedPassword,string providedPassword)
        {            
            return _userManager.PasswordHasher.VerifyHashedPassword(user, hashedPassword,providedPassword);
        }
        public string HashPassword(StormyCustomer user,string password)
        {
            return _userManager.PasswordHasher.HashPassword(user,password);
        }
        public Task SignOutAsync()
        {
            return Task.FromResult(_signInManager.SignOutAsync());
        }

        public IEnumerable<Claim> BuildClaims(StormyCustomer user)
        {
            if (user == null) throw new ArgumentNullException($"Given user object was null, check the stack trace");
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Iat,value: DateTimeOffset.UtcNow.ToString("yyyy-MM-dd")),
            };            
            

            // claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role.Role.Name)));
            claims.Add(new Claim(ClaimTypes.Role,user.Role.Name));
            return claims;
        }
        public Task<string> GeneratePasswordResetTokenAsync(StormyCustomer user)
        {
            return _userManager.GeneratePasswordResetTokenAsync(user);
        }
        public Task<bool> IsEmailConfirmedAsync(StormyCustomer user)
        {
            return _userManager.IsEmailConfirmedAsync(user);
        }

        public async Task<Result> AssignUserToRole(StormyCustomer user, string roleName)
        {
            user.Role = _roleManager.Roles.Where(r => string.Equals(r.Name,roleName,StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            return await this.EditUserAsync(user);
        }
        public async Task<Result> DeleteUserAsync(StormyCustomer user,string password)
        {
            var result = await _signInManager.CheckPasswordSignInAsync(user, password,false);        
            if (!result.Succeeded)
            {                
                return Result.Fail("password don't match, please, check the password");
            }
            //if(result == PasswordVerificationResult.SuccessRehashNeeded)
            //{
            //TODO: need to rehash password and set the new hash on database
            //}            
            var identityResult = await _userManager.DeleteAsync(user);
            if (!identityResult.Succeeded) return Result.Fail("We failed to delete the user, please try again later",user);
            return Result.Ok("account was deleted with success!");
        }
        private Result CreateErrorMessage(IdentityResult result)
        {
                var strBuilder = new StringBuilder();
                result.Errors.ToList().ForEach(e => strBuilder.AppendLine($"Code:{e.Code},Description{e.Description}"));
                return Result.Fail(strBuilder.ToString());
        }
    }
}
