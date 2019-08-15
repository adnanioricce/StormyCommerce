using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Services.Authentication
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public UserIdentityService(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
           
        }
        public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password)
        {           
            var result = await _userManager.CreateAsync(user, password);
            if (result == null)
            {
                throw new ArgumentNullException($"was not possible to create user,result is null {result}, on {nameof(CreateUserAsync)}");
            }
            if (result.Errors.Count() > 0)
            {
                result.Errors.ToList().ForEach(error => Console.WriteLine($"Error creating user: code:{error.Code},{error.Description}"));
            }
            if(result.Succeeded == true)
            {                
                return result;
            }
            return result;
            
                     
        }
        public ApplicationUser GetUserByEmail(string email)
        {
            return _userManager.Users.FirstOrDefault(user => user.Email == email);
        }
        public UserManager<ApplicationUser> GetUserManager() => _userManager;        
        public async Task<SignInResult> PasswordSignInAsync(ApplicationUser user, string password,bool isPersistent = true,bool lockoutInFailure = false)
        {
            return await _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutInFailure);
        }        
        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
