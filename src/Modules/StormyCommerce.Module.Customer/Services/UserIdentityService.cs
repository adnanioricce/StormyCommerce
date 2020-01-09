
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using User = StormyCommerce.Core.Entities.User;
using Role = StormyCommerce.Core.Entities.Role;
namespace StormyCommerce.Module.Customer.Services
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;       
        private readonly RoleManager<Role> _roleManager;        
        public UserIdentityService(SignInManager<User> signInManager,
            UserManager<User> identityRepository,
            RoleManager<Role> roleManager)
        {
            _signInManager = signInManager;
            _userManager = identityRepository;     
            _roleManager = roleManager;            
            _userManager.Users                                                
                .Include(u => u.Addresses)       
                .Load();
            _roleManager.Roles.Load();            
        }

        public async Task<IdentityResult> CreateUserAsync(User user, string password)
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
            }
            if (!result.Succeeded)
            {
                //TODO:Throw a error?
                return result;
            }
            return result;
        }
        
        public Task<IdentityResult> ConfirmEmailAsync(User user,string code)
        {
            return _userManager.ConfirmEmailAsync(user,code);
        }
        public Task<IdentityResult> ResetPasswordAsync(User user,string token,string newPassword)
        {
            return _userManager.ResetPasswordAsync(user,token,newPassword);
        }
        public User GetUserByEmail(string email)
        {           
            return _userManager.Users
                .FirstOrDefault(u => u.Email == email);
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userManager.Users                                    
                .Include(u => u.Addresses)                    
                .FirstOrDefaultAsync(u => string.Equals(u.Email, email,StringComparison.OrdinalIgnoreCase)).ConfigureAwait(true);
        }
        public User GetUserByUsername(string username)
        {
            return _userManager.Users.FirstOrDefault(u => string.Equals(u.UserName,username,StringComparison.OrdinalIgnoreCase));
        }
        public User GetUserById(long userId)
        {            
            return _userManager.Users.First(u => u.Id == userId);
        }
        public Task<User> GetUserByClaimPrincipal(ClaimsPrincipal principal)
        {            
            var email = principal.Claims.FirstOrDefault(c => c.Type.Contains("emailaddress"))?.Value ?? principal.FindFirstValue(JwtRegisteredClaimNames.Email);
            return GetUserByEmailAsync(email);
        }
        public UserManager<User> GetUserManager() => _userManager;

        public Task<SignInResult> PasswordSignInAsync(User user, string password, bool isPersistent = true, bool lockoutInFailure = false)
        {
            return _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutInFailure);
        }

        public Task<string> CreateEmailConfirmationCode(User user)
        {
            return _userManager.GenerateEmailConfirmationTokenAsync(user);
        }
        public async Task<Result> EditUserAsync(User customer)
        {
            var identityResult = await _userManager.UpdateAsync(customer).ConfigureAwait(true);
            if (identityResult.Errors.Any())
            {
                return CreateErrorMessage(identityResult);
            }
            return Result.Ok();
        }
        public PasswordVerificationResult VerifyHashPassword(User user,string hashedPassword,string providedPassword)
        {            
            return _userManager.PasswordHasher.VerifyHashedPassword(user, hashedPassword,providedPassword);
        }
        public string HashPassword(User user,string password)
        {
            return _userManager.PasswordHasher.HashPassword(user,password);
        }
        public Task SignOutAsync()
        {
            return Task.FromResult(_signInManager.SignOutAsync());
        }

        public IEnumerable<Claim> BuildClaims(User user)
        {
            if (user == null) throw new ArgumentNullException($"Given user object was null, check the stack trace");
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserGuid.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Iat,value: DateTimeOffset.UtcNow.ToString("yyyy-MM-dd")),
            };            
            
            claims.AddRange(user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Role.Name)));            
            return claims;
        }
        public Task<string> GeneratePasswordResetTokenAsync(User user)
        {
            return _userManager.GeneratePasswordResetTokenAsync(user);
        }
        public Task<bool> IsEmailConfirmedAsync(User user)
        {
            return _userManager.IsEmailConfirmedAsync(user);
        }

        public async Task<Result> AssignUserToRole(User user, string roleName)
        {            
            throw new NotImplementedException();
        }
        public async Task<Result> DeleteUserAsync(User user,string password)
        {
            var result = await _signInManager.CheckPasswordSignInAsync(user, password,false);        
            if (!result.Succeeded)
            {                
                return Result.Fail("password don't match, please, check the password");
            }
            user.RemoveRelations();      
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
