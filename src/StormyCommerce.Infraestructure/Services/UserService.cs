using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Entities;
using AutoMapper;
using System.Collections.Generic;
using StormyCommerce.Infraestructure.Models;
using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Core.Models.GatewayResponses;
using AutoMapper.QueryableExtensions;

namespace StormyCommerce.Infraestructure.Services
{
	public class UserIdentityService : IUserAuthService<AppUser>
	{
		#region Variables
		private readonly IUserIdentityRepository repository;
		private readonly IMapper mapper; 
		private readonly IUserValidator<AppUser> userValidator; 
		private readonly IPasswordHasher<AppUser> passwordHasher; 
		private readonly IPasswordValidator<AppUser> passwordValidator; 
		private readonly SignInManager<AppUser> signInManager; 
		#endregion
		public UserIdentityService(IUserIdentityRepository _repository, 
				IUserValidator<AppUser> _userValidator,
				IPasswordHasher<AppUser> _passwordHasher, 
				IPasswordValidator<AppUser> _passwordValidator, 
				SignInManager<AppUser> _signInManager, 
				IMapper _mapper)
		{
			repository = _repository;
			userValidator = _userValidator; 
			passwordHasher = _passwordHasher; 
			passwordValidator = _passwordValidator;
			signInManager = _signInManager; 
			mapper = _mapper;
		}
		//TODO: Create the mappings for User to AppUser and from IdentityResult to IdentityResponse
		public async Task<BaseIdentityResponse> Create(AppUser user,string password)
		{
			return mapper.Map<BaseIdentityResponse>(await repository.Create(mapper.Map<AppUser>(user),password));
		}
		public async Task<BaseIdentityResponse> Delete(AppUser user)
		{
			return mapper.Map<BaseIdentityResponse>(await repository.Delete(mapper.Map<AppUser>(user)));
		}
		
		//Automapper is awesome...
		public IQueryable<AppUser> Get()
		{						
			return repository.Get().ProjectTo<AppUser>();
		}		
		public UserManager<AppUser> GetUserManager()
		{
			return repository.GetUserManager();
		}
		public async Task<SignInResponse> PasswordSignInAsync(AppUser user,string password,bool lockoutInFailure,bool isPersistent)
		{
			return mapper.Map<SignInResponse>(await signInManager.PasswordSignInAsync(mapper.Map<AppUser>(user),password,lockoutInFailure,isPersistent)); 
		}
		public string HashPassword(AppUser user,string password)
		{
			return passwordHasher.HashPassword(mapper.Map<AppUser>(user),password);
		}
		public async Task SignOutAsync()
		{
			await signInManager.SignOutAsync();
		}
		public async Task<BaseIdentityResponse> ValidatePassword(AppUser user,string password)
		{
			return mapper.Map<BaseIdentityResponse>(await passwordValidator.ValidateAsync(repository.GetUserManager(),mapper.Map<AppUser>(user),password));
		}
		public async Task<BaseIdentityResponse> ValidateUser(AppUser user)
		{
			return mapper.Map<BaseIdentityResponse>(await userValidator.ValidateAsync(repository.GetUserManager(),mapper.Map<AppUser>(user)));
		}
        public AppUser GetByEmail(string email)
		{
			return mapper.Map<AppUser>(repository.GetByEmail(email));
		}
        public async Task<BaseIdentityResponse> Update(AppUser user)
        {
			return mapper.Map<BaseIdentityResponse>(await repository.Update(mapper.Map<AppUser>(user)));
        }
    }
}
