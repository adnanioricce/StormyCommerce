using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Data.Stores;
using StormyCommerce.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Services
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly SignInManager<StormyCustomer> _signInManager;
        private readonly UserManager<StormyCustomer> _userManager;       

        public UserIdentityService(SignInManager<StormyCustomer> signInManager,
            UserManager<StormyCustomer> identityRepository)
        {
            _signInManager = signInManager;
            _userManager = identityRepository;            
        }

        public async Task<IdentityResult> CreateUserAsync(StormyCustomer user, string password)
        {
            if (user == null || password == null) throw new ArgumentNullException("was not possible to create user, the given arguments was null");
            var result = await _userManager.CreateAsync(user, password);
            if (result == null)
            {
                throw new ArgumentNullException($"was not possible to create user,result is null {result}, on {nameof(CreateUserAsync)}");
            }
            if (result.Errors.Count() > 0)
            {
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
            return _userManager.Users.FirstOrDefault(u => u.Email == email);
        }
        public StormyCustomer GetUserByUsername(string username)
        {
            return _userManager.Users.FirstOrDefault(u => u.UserName == username);
        }
        public StormyCustomer GetUserById(string userId)
        {
            return _userManager.Users.First(u => string.Equals(u.Id, userId));
        }
        public async Task<StormyCustomer> GetUserByClaimPrincipal(ClaimsPrincipal principal)
        {
            return await _userManager.GetUserAsync(principal);
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
        public Task EditUserAsync(StormyCustomer customer)
        {
            return _userManager.UpdateAsync(customer);
        }
        public PasswordVerificationResult VerifyHashPassword(StormyCustomer user,string hashedPassword,string providedPassword)
        {
            return _userManager.PasswordHasher.VerifyHashedPassword(user,hashedPassword,providedPassword);
        }
        public string HashPassword(StormyCustomer user,string password)
        {
            return _userManager.PasswordHasher.HashPassword(user,password);
        }
        public Task SignOutAsync()
        {
            return Task.FromResult(_signInManager.SignOutAsync());
        }

        public async Task<IEnumerable<Claim>> BuildClaims(StormyCustomer user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Iat,DateTimeOffset.UtcNow.ToString()),               
            };
            var userRoles = await _userManager.GetRolesAsync(user);
            claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));
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

        public Task<IdentityResult> AssignUserToRole(StormyCustomer user, string roleName)
        {
            return _userManager.AddToRoleAsync(user, roleName);
        }
    }
}
