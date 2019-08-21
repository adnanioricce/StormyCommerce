using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
// using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Services.Authentication
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;        
        private readonly IUserIdentityRepository _identityRepository;
        
        public UserIdentityService(SignInManager<ApplicationUser> signInManager,            
            IUserIdentityRepository identityRepository)
        {
            _signInManager = signInManager;            
            _identityRepository = identityRepository;
        }
        public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password)
        {           
            
            var result = await _identityRepository.Create(user,password);
            if (result == null)
            {
                throw new ArgumentNullException($"was not possible to create user,result is null {result}, on {nameof(CreateUserAsync)}");
            }
            if (result.Errors.Count() > 0)
            {
                result.Errors.ToList().ForEach(error => Console.WriteLine($"Error creating user: code:{error.Code},{error.Description}"));
            }
            if(!result.Succeeded)
            {                
                //TODO:Throw a error?
                return result;
            }
            return result;
            
                     
        }
        public ApplicationUser GetUserByEmail(string email)
        {            
            return _identityRepository.GetByEmail(email);
        }
        public UserManager<ApplicationUser> GetUserManager() => _identityRepository.GetUserManager();        
        public async Task<SignInResult> PasswordSignInAsync(ApplicationUser user, string password,bool isPersistent = true,bool lockoutInFailure = false)
        {            
            return await _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutInFailure);
        }        
        public async Task<string> CreateEmailConfirmationCode(ApplicationUser user,string email)
        {
            return String.Empty;
        }
        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<List<Claim>> BuildClaims(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                // new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                // new Claim(JwtRegisteredClaimNames.Email, user.Email),
            };
            var userManager = _identityRepository.GetUserManager();
            var userRoles = await  userManager.GetRolesAsync(user);
            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            return claims;
        }
    }
}
