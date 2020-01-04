using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Areas.Customer.Controllers
{
    //[Area("Customer")]    
    [ApiController]
    [Route("api/[controller]")]    
    [EnableCors("Default")]
    public class AuthenticationController : Controller
    {
        private readonly IUserIdentityService _identityService;
        private readonly IEmailSender _emailSender;
        private readonly ITokenService _tokenService;
        private readonly IAppLogger<AuthenticationController> _logger;        
        private readonly IMapper _mapper;
        public AuthenticationController(IUserIdentityService identityService,
        ITokenService tokenService,
        IEmailSender emailSender,
        IAppLogger<AuthenticationController> logger,        
        IMapper mapper)
        {
            _identityService = identityService;
            _emailSender = emailSender;
            _tokenService = tokenService;
            _logger = logger;            
            _mapper = mapper;
        }

        [HttpPost("login")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromBody]SignInVm signInVm)
        {
            var user = _identityService.GetUserByEmail(signInVm.Email);

            if (user == null) return BadRequest("User don't exists");

            var signInResult = await _identityService.PasswordSignInAsync(user, signInVm.Password, true, true);

            if (!signInResult.Succeeded) return BadRequest($"fail to sign in");

            _logger.LogInformation("user logged in with success");

            var claims = _identityService.BuildClaims(user);//TODO:Replace this with a extension method
            var token = new AuthResponse{ 
                AccessToken = _tokenService.GenerateAccessToken(claims),
                RefreshToken = _tokenService.GenerateRefreshToken(),
                ExpiresIn = new DateTimeOffset().AddMinutes(Convert.ToInt32(Container.Configuration["Authentication:Jwt:AccessTokenDurationInMinutes"]))
            };            
            user.RefreshTokenHash = token.RefreshToken;
            //TODO:Add redis to handle things like things like this
            await _identityService.EditUserAsync(user);
            //TODO:Write JWT refresh token logic
            return Ok(Result.Ok(token));
        }

        [HttpPost("register")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsync(SignUpVm signUpVm)
        {
            var user = _identityService.GetUserByEmail(signUpVm.Email);

            if (user != null) return BadRequest("User already exists");

            user = _identityService.GetUserByUsername(signUpVm.UserName);

            if(user != null) return BadRequest("username already exists");

            var result = await _identityService.CreateUserAsync(new User
            {                
                UserName = signUpVm.UserName,
                Email = signUpVm.Email,                            
                
            }, signUpVm.Password);    
                   
            if (!result.Succeeded) return BadRequest("Don't was possible to create user");

            var appUser = _identityService.GetUserByEmail(signUpVm.Email);            
            if (appUser == null) _logger.LogError($"User is null when tried to get user after create operation on {nameof(RegisterAsync)},at {DateTimeOffset.UtcNow}");
            await _identityService.AssignUserToRole(appUser,Roles.Guest); 
            var verificationCode = await _identityService.CreateEmailConfirmationCode(appUser);

            if (verificationCode == null) _logger.LogError($"verification code is null on {nameof(RegisterAsync)},at {DateTimeOffset.UtcNow}");

            var callbackUrl = Url.Action(
                action: "ConfirmEmailAsync",
                controller:"Account",                
                values: new { userId = appUser.Id, code = verificationCode },
                protocol:Request.Scheme
                );
            if (callbackUrl == null) return BadRequest("Callback url was null");
            await _emailSender.SendEmailAsync(appUser.Email, "Email Confirmation", $"click on the link to confirm your account<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>link</a>", true);
            _logger.LogInformation($"Confirmation email sended.At {DateTimeOffset.UtcNow}");
            return Ok();
        }        
        [AllowAnonymous]
        [HttpPost("refresh_token")]
        [IgnoreAntiforgeryToken]
        [ValidateModel]
        public async Task<IActionResult> RefreshToken(RefreshTokenModel model)
        {
            var principal = _tokenService.GetPrincipalFromExpiredToken(model.Token);
            if(principal == null)
            {
                return BadRequest(new { Error = "Invalid token" });
            }
            var user = await _identityService.GetUserByClaimPrincipal(principal);
            var verifyRefreshTokenResult = _identityService.VerifyHashPassword(user, user.RefreshTokenHash, model.RefreshToken);
            if(verifyRefreshTokenResult == PasswordVerificationResult.Success)
            {
                var claims = _identityService.BuildClaims(user);
                var newToken = _tokenService.GenerateAccessToken(claims);
                return Ok(new { token = newToken });
            }
            return Forbid();
        }
        
        [HttpPost("ForgotPassword")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [ValidateModel]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {            
            var user =  _identityService.GetUserByEmail(model.Email);            

            //TODO:what if the user really forgot? how he will access it?
            if (user == null || !(await _identityService.IsEmailConfirmedAsync(user))) return BadRequest();            
            _logger.LogInformation("user validated");            

            var code = await _identityService.GeneratePasswordResetTokenAsync(user);            

            var callbackUrl = Url.Action("ResetPasswordAsync", "Account", 
            new { userId = user.Id, code = code },
             protocol: HttpContext.Request.Scheme);            
            await _emailSender.SendEmailAsync(model.Email, "Reset Password",
                $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");                        
            _logger.LogInformation("password recover email Sended");
            return Ok();
        }

    }
}
