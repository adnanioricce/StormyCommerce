using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Models.GatewayResponses;

namespace StormyCommerce.Core.Interfaces
{
	public interface IUserAuthService<T> where T : class
	{
		IQueryable<T> Get(); 
		T GetByEmail(string email); 
		Task<BaseIdentityResponse> Create(T user,string password); 
		Task<BaseIdentityResponse> Update(T user); 
		Task<BaseIdentityResponse> Delete(T user); 
		Task<BaseIdentityResponse> ValidatePassword(T user,string password); 
		Task<BaseIdentityResponse> ValidateUser(T user); 
		Task<SignInResponse> PasswordSignInAsync(T user,string password,bool lockoutOnFailure,bool isPersistent);
		Task SignOutAsync(); 
		string HashPassword(T user,string password); 
	}
}
