using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Controllers;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Interfaces;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Controllers
{
    [Area("Customer")]
    public class AuthenticationController : BaseApiController
    {
        private IUserIdentityService _identityService;
        private IEmailSender _emailSender;        
	    private ITokenService _tokenService;
        public AuthenticationController(IUserIdentityService identityService,ITokenService tokenService,IEmailSender emailSender)
        {
            _identityService = identityService;
            _emailSender = emailSender;
	        _tokenService = tokenService;
        }
        [HttpPost("signin")]
	    [ValidateModel]
        public async Task<IActionResult> LoginAsync([FromBody]SignInVm signInVm)
        {
	        var user = _identityService.GetUserByEmail(signInVm.NameOrEmail);	    
	        if(user == null) return BadRequest("User don't exists");
	    
    	    var signInResult = _identityService.PasswordSignInAsync(user,signInVm.Password,true,true);

	        if(signInResult.Succeeded == false)	return BadRequest();
	    
	        var claims = await BuildClaims(user);//TODO:Replace this with a extension method
	        var token = _tokenService.GenerateAccessToken(claims);
	        //TODO:Write JWT refresh token logic
            return Ok(new {token = token});
        }
        [HttpPost("signup")]
        public async Task<IActionResult> RegisterAsync(SignUpVm signUpVm)
        {            
            var user = identityService.GetUserByEmail(signUpVm.Email);
            
            if(user != null) return BadRequest("User already exists");
            
            var appUser = new ApplicationUser{
                //Actually, maybe is better have a username
                UserName = signUpVm.Username,
                Email = signUpVm.Email,                
            };
            
            var result = identityService.CreateUser(appUser,signUpVm.Password)

            if(!result.Success) return BadRequest("Don't was possible to create user");
            //TODO:You are really done?
            return Ok();
        }        	
	    private async Task<List<Claim>> BuildClaims(ApplicationUser user)
	    {
	        var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            };

            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            return claims;
	    }
	
    }
}
