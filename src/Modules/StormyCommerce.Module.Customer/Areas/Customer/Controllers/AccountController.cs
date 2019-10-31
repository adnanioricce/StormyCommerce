using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
namespace StormyCommerce.Module.Customer.Areas.Customer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    [EnableCors("Default")]
    public class AccountController : Controller
    {
        private readonly IUserIdentityService _identityService;
        private readonly ICustomerService _customerService;        
        private readonly IAppLogger<AuthenticationController> _logger;
        public AccountController(IUserIdentityService identityService,ICustomerService customerService,IAppLogger<AuthenticationController> logger)
        {
            _identityService = identityService;
            _customerService = customerService;            
            _logger = logger;
        }
        [HttpGet("ConfirmEmail")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmailAsync(string userId,string code)
        {            
            var appUser = _identityService.GetUserById(userId);

            if (appUser == null) return BadRequest("user with given email not found");

            _logger.LogInformation($"User validated at {DateTimeOffset.UtcNow}");

            var result = await _identityService.ConfirmEmailAsync(appUser,code);

            if(!result.Succeeded) return BadRequest();            

            _logger.LogInformation($"Email confirmed at {DateTimeOffset.UtcNow}");

            var confirmedUser = _identityService.GetUserById(userId);
            await _identityService.AssignUserToRole(confirmedUser, Roles.Customer);
            var customer = new StormyCustomer
            {
                Email = confirmedUser.Email,
                EmailConfirmed = confirmedUser.EmailConfirmed,
                NormalizedEmail = confirmedUser.NormalizedEmail,
                UserId = confirmedUser.Id,
                PhoneNumber = confirmedUser.PhoneNumber,
                PhoneNumberConfirmed = confirmedUser.PhoneNumberConfirmed,
                UserName = confirmedUser.UserName,
                NormalizedUserName = confirmedUser.NormalizedUserName,
                RefreshTokenHash = confirmedUser.RefreshTokenHash,     
                Role = Roles.Customer,
                LastModified = DateTimeOffset.UtcNow,
                CreatedOn = DateTimeOffset.UtcNow,
                IsDeleted = false
            };

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
    }
}
