using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;

namespace StormyCommerce.Infraestructure.Repositories
{
    public class UserIdentityRepository : IUserIdentityRepository
    {
        private readonly UserManager<AppUser> userManager;
        public UserIdentityRepository(UserManager<AppUser> _userManager)
        {
            userManager = _userManager;
        }
        public async Task<IdentityResult> Create(AppUser user, string password)
        {
            return await userManager.CreateAsync(user,password);
        }
        public async Task<IdentityResult> Delete(AppUser user)
        {
            return await userManager.DeleteAsync(user);
        }
        public IQueryable<AppUser> Get() => userManager.Users;        
        public AppUser GetByEmail(string Email) => userManager.Users.FirstOrDefault(usr => usr.Email == Email);        

        public UserManager<AppUser> GetUserManager() => userManager;
        public async Task<IdentityResult> Update(AppUser user)
        {
            return await userManager.UpdateAsync(user);
        }
    }
}
