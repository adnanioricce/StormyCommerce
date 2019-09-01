using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
// using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Threading.Tasks;
namespace StormyCommerce.Module.Customer.Services
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;        
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IStormyRepository<StormyCustomer> _customerRepository;        
        public UserIdentityService(SignInManager<ApplicationUser> signInManager,            
            UserManager<ApplicationUser> identityRepository,
            IStormyRepository<StormyCustomer> customerRepository)
        {
            _signInManager = signInManager;            
            _userManager = identityRepository;
            _customerRepository = customerRepository;
        }
        public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password)
        {
            if (user == null || password == null) throw new ArgumentNullException("was not possible to create user, the given arguments was null");                
            var result = await _userManager.CreateAsync(user,password);
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
            return _userManager.Users.FirstOrDefault(u => u.Email == email);
        }
        public UserManager<ApplicationUser> GetUserManager() => _userManager;        
        public async Task<SignInResult> PasswordSignInAsync(ApplicationUser user, string password,bool isPersistent = true,bool lockoutInFailure = false)
        {            
            return await _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutInFailure);
        }        
        public async Task<string> CreateEmailConfirmationCode(ApplicationUser user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);                       
        }
        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<IEnumerable<Claim>> BuildClaims(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),                
            };                        
            var userRoles = await  _userManager.GetRolesAsync(user);
            claims.AddRange(userRoles.Select(role => new Claim(ClaimsIdentity.DefaultRoleClaimType,role)));            

            return claims;
        }
    }
}
