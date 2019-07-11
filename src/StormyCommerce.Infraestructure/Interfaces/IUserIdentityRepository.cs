using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Entities;

namespace StormyCommerce.Infraestructure.Interfaces
{
	public interface IUserIdentityRepository
	{
		IQueryable<ApplicationUser> Get(); 
		ApplicationUser GetByEmail(string Email); 
		Task<IdentityResult> Create(ApplicationUser user,string password); 
		Task<IdentityResult> Update(ApplicationUser user); 
		Task<IdentityResult> Delete(ApplicationUser user); 
		UserManager<ApplicationUser> GetUserManager(); 
	}
}
