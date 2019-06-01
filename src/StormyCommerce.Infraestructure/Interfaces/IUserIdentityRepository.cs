using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Models.GatewayResponses;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Models;

namespace StormyCommerce.Infraestructure.Interfaces
{
	public interface IUserIdentityRepository
	{
		IQueryable<AppUser> Get(); 
		AppUser GetByEmail(string Email); 
		Task<IdentityResult> Create(AppUser user,string password); 
		Task<IdentityResult> Update(AppUser user); 
		Task<IdentityResult> Delete(AppUser user); 
		UserManager<AppUser> GetUserManager(); 
	}
}
