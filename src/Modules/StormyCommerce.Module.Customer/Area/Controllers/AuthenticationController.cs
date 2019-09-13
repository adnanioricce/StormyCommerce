using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Area.ViewModels;
using StormyCommerce.Module.Customer.Services;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize]
    [EnableCors("Default")]
    public class AuthenticationController : Controller
    {
        private IUserIdentityService _identityService;
        private IEmailSender _emailSender;
        private ITokenService _tokenService;

        public AuthenticationController(IUserIdentityService identityService,
        ITokenService tokenService,
        IEmailSender emailSender)
        {
            _identityService = identityService;
            _emailSender = emailSender;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromBody]SignInVm signInVm)
        {
            var user = _identityService.GetUserByEmail(signInVm.Email);

            if (user == null) return BadRequest("User don't exists");

            var signInResult = await _identityService.PasswordSignInAsync(user, signInVm.Password, true, true);

            if (signInResult.Succeeded == false) return BadRequest("fail to sign in ");

            var claims = await _identityService.BuildClaims(user);//TODO:Replace this with a extension method
            var token = _tokenService.GenerateAccessToken(claims);
            //TODO:Write JWT refresh token logic
            return Ok(new { token = token });
        }

        [HttpPost("register")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsync(SignUpVm signUpVm)
        {
            var user = _identityService.GetUserByEmail(signUpVm.Email);

            if (user != null) return BadRequest("User already exists");

            var result = await _identityService.CreateUserAsync(new ApplicationUser
            {
                UserName = signUpVm.Username,
                Email = signUpVm.Email,
            }, signUpVm.Password);
            if (!result.Succeeded) return BadRequest("Don't was possible to create user");

            var appUser = _identityService.GetUserByEmail(signUpVm.Email);

            if (appUser == null) throw new System.Exception("User is null");

            var verificationCode = await _identityService.CreateEmailConfirmationCode(appUser);

            if (verificationCode == null) throw new System.Exception("verification code is null");

            var callbackUrl = Url.Page(
                "/Authentication/ConfirmEmail",
                pageHandler: null,
                values: new { userId = user.Id, code = verificationCode },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(appUser.Email, "Email Confirmation", $"click on the link to confirm your account<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>link</a>", true);
            return Ok();
        }
    }
}
