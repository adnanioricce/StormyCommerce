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
        private readonly UserManager<ApplicationUser> userManager;
        public UserIdentityRepository(UserManager<ApplicationUser> _userManager)
        {
            userManager = _userManager;
        }
        public async Task<IdentityResult> Create(ApplicationUser user, string password)
        {
            return await userManager.CreateAsync(user,password);
        }
        public async Task<IdentityResult> Delete(ApplicationUser user)
        {
            return await userManager.DeleteAsync(user);
        }
        public IQueryable<ApplicationUser> Get() => userManager.Users;        
        public ApplicationUser GetByEmail(string Email) => userManager.Users.FirstOrDefault(usr => usr.Email == Email);        

        public UserManager<ApplicationUser> GetUserManager() => userManager;
        public async Task<IdentityResult> Update(ApplicationUser user)
        {
            return await userManager.UpdateAsync(user);
        }
    }
}
