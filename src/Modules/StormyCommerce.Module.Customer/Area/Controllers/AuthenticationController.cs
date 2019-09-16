using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Area.ViewModels;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles.Guest)]
    [EnableCors("Default")]
    public class AuthenticationController : Controller
    {
        private readonly IUserIdentityService _identityService;
        private readonly IEmailSender _emailSender;
        private readonly ITokenService _tokenService;
        private readonly IAppLogger<AuthenticationController> _logger;
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public AuthenticationController(IUserIdentityService identityService,
        ITokenService tokenService,
        IEmailSender emailSender,
        IAppLogger<AuthenticationController> logger,
        ICustomerService customerService,
        IMapper mapper)
        {
            _identityService = identityService;
            _emailSender = emailSender;
            _tokenService = tokenService;
            _logger = logger;
            _customerService = customerService;
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

            if (signInResult.Succeeded == false) return BadRequest("fail to sign in ");

            _logger.LogInformation("user logged in with success");

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

            user = _identityService.GetUserByUsername(signUpVm.UserName);

            if(user != null) return BadRequest("username already exists");

            var result = await _identityService.CreateUserAsync(new ApplicationUser
            {                
                UserName = signUpVm.UserName,
                Email = signUpVm.Email,
            }, signUpVm.Password);
            if (!result.Succeeded) return BadRequest("Don't was possible to create user");

            var appUser = _identityService.GetUserByEmail(signUpVm.Email);

            if (appUser == null) _logger.LogError($"User is null when tried to get user after create operation on {nameof(RegisterAsync)},at {DateTimeOffset.UtcNow}");

            var verificationCode = await _identityService.CreateEmailConfirmationCode(appUser);

            if (verificationCode == null) _logger.LogError($"verification code is null on {nameof(RegisterAsync)},at {DateTimeOffset.UtcNow}");

            var callbackUrl = Url.Action(
                "ConfirmEmail","/api/Authentication",                
                values: new { userId = appUser.Id, code = verificationCode },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(appUser.Email, "Email Confirmation", $"click on the link to confirm your account<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>link</a>", true);
            _logger.LogInformation($"Confirmation email sended.At {DateTimeOffset.UtcNow}");
            return Ok();
        }
        [HttpPost("ConfirmEmail")]
        [ValidateModel]
        public async Task<IActionResult> ConfirmEmailAsync(string email,string code)
        {
            if (email == null || code == null ) return BadRequest();

            var appUser = _identityService.GetUserByEmail(email);

            if (appUser == null) return BadRequest("user with given email not found");
            _logger.LogInformation($"User validated at {DateTimeOffset.UtcNow}");
            var result = await _identityService.ConfirmEmailAsync(appUser,code);
            if(!result.Succeeded) return BadRequest();            
            _logger.LogInformation($"Email confirmed at {DateTimeOffset.UtcNow}");
            var customer = _mapper.Map<ApplicationUser, StormyCustomer>(_identityService.GetUserByEmail(email));                        
            await _customerService.CreateCustomerAsync(customer);
            _logger.LogInformation($"new customer registered at {DateTimeOffset.UtcNow}");            
            return Ok(new { Message = $"Email confirmation performed With Success at {DateTimeOffset.UtcNow}" });            
        }
        [HttpPost("ResetPassword")]
        [ValidateModel]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordViewModel model)
        {                        
            var user = _identityService.GetUserByEmail(model.Email);
            if (user == null) return BadRequest();            
            var result = await _identityService.ResetPasswordAsync(user, model.Code, model.Password);
            if (!result.Succeeded) return BadRequest();                        
            
            return Ok();
        }
        [HttpPost("ForgotPassword")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [ValidateModel]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {            
            var user =  _identityService.GetUserByEmail(model.Email);
            _logger.LogInformation("Searching for user");
            if (user == null || !(await _identityService.IsEmailConfirmedAsync(user))) return BadRequest();            
            _logger.LogInformation("user validated");
            // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
            // Send an email with this link
            var code = await _identityService.GeneratePasswordResetTokenAsync(user);
            _logger.LogInformation("reset password Code generated");
            var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
            _logger.LogInformation("callback url created");
            await _emailSender.SendEmailAsync(model.Email, "Reset Password",
                $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");                        
            _logger.LogInformation("password recover email Sended");
            return Ok();
        }

    }
}
