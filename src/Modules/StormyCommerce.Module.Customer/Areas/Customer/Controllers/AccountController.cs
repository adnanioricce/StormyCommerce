using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Models.Requests;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace StormyCommerce.Module.Customer.Areas.Customer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    [EnableCors("Default")]
    public class AccountController : Controller
    {
        private readonly IUserIdentityService _identityService;          
        private readonly IEmailSender _emailSender;
        private readonly IAppLogger<AccountController> _logger;
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public AccountController(IUserIdentityService identityService,
        IEmailSender emailSender,
        IAppLogger<AccountController> logger,
        ICustomerService customerService,
        IMapper mapper)
        {
            _identityService = identityService;                    
            _emailSender = emailSender;
            _logger = logger;
            _customerService = customerService;
            _mapper = mapper;
        }
        [HttpGet("ConfirmEmail")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmailAsync(string userId,string code)
        {            
            var appUser = _identityService.GetUserById(userId);
            if (appUser == null) return BadRequest("user with given email not found");            
            var result = await _identityService.ConfirmEmailAsync(appUser,code);
            if(!result.Succeeded) return BadRequest();                              
            await _identityService.AssignUserToRole(appUser, Roles.Customer);                      
            return Ok(Result.Ok($"Email confirmation performed With Success at {DateTimeOffset.UtcNow}"));            
        }

        [HttpPost("reset_password")]
        [ValidateModel]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordViewModel model)
        {
            var user = _identityService.GetUserByEmail(model.Email);

            if (user == null) return BadRequest();
            var result = await _identityService.ResetPasswordAsync(user, model.Code, model.Password);

            if (!result.Succeeded) return BadRequest();

            return Ok(Result.Ok(result));
        }     
        [HttpPost("add_shipping_address")]
        [Authorize(Roles.Customer)]
        [ValidateModel]
        //TODO:Duplicated Logic, too much ifs, refactor this
        public async Task<IActionResult> AddDefaultShippingAddress([FromBody]CreateShippingAddressRequest model)
        {            
            var user = await GetCurrentUser();            
            user.Addresses.Add(new CustomerAddress(model.Address)
            {
                Type = model.Type,
                IsDefault = model.IsDefault,
                WhoReceives = string.IsNullOrEmpty(model.WhoReceives) ? "" : model.WhoReceives
            });
            var result = await _identityService.EditUserAsync(user);
            if (!result.Success) return BadRequest(result);
            return Ok(new
            {
                message = "address added with success",
                result = result
            });
                            
        }                
        [HttpPut("edit_account")]
        [Authorize(Roles.Customer)]
        [ValidateModel]
        public async Task<IActionResult> EditAccount([FromBody]EditCustomerRequest request)
        {
            var currentUser = await this.GetCurrentUser();
            _mapper.Map<EditCustomerRequest, StormyCustomer>(request,currentUser);
            var result = await _identityService.EditUserAsync(currentUser);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
        [HttpPut("edit_shipping_address")]
        [Authorize(Roles.Customer)]
        [ValidateModel]
        public async Task<IActionResult> EditAddress([FromBody]EditCustomerAddressRequest request) 
        {
            var currentUser = await this.GetCurrentUser();
            
            var result = await _identityService.EditUserAsync(currentUser);
            if (!result.Success) return BadRequest(result);
            return Ok(new
            {
                message = "shipping address edited with success",
                result = result
            });
        }
        [HttpPost("resend_confirm_email")]
        [Authorize(Roles.Guest)]
        [ProducesDefaultResponseType(typeof(Result))]
        public async Task<IActionResult> ResendConfirmationEmail()
        {
            
            var user = await GetCurrentUser();
            var code = await _identityService.CreateEmailConfirmationCode(user);
            var callbackUrl = Url.Action("ConfirmEmailAsync", "Account", 
            new { userId = user.Id, code = code },
             protocol: HttpContext.Request.Scheme);            
            await _emailSender.SendEmailAsync(user.Email, "Reset Password",
                $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");    
            return Ok(Result.Ok($"confirmation email was sended to {user.Email} at {DateTime.UtcNow}"));
        }
        [HttpGet("get_current_user")]
        [Authorize(Roles.Customer)]
        public async Task<CustomerDto> GetCurrentCustomer()
        {
            var user = await GetCurrentUser();
            var customer = new CustomerDto(user);
            return customer;
        }
        #region Delete Operations 
        [HttpDelete("delete")]
        [Authorize(Roles.Customer)]
        public async Task<IActionResult> DeleteAccount(string password)
        {
            var currentUser = await GetCurrentUser();
            var result = await _identityService.DeleteUserAsync(currentUser, password);
            var isInternalError = currentUser is Result<StormyCustomer>;
            //This is a little tricky...
            if (isInternalError) return StatusCode(500, result);
            if (!result.Success) return BadRequest(result);
            return Ok(result);            
        }
        [HttpDelete("delete_address")]
        [Authorize(Roles.Customer)]
        public async Task<IActionResult> DeleteAddress(long addressId)
        {
            var currentUser = await GetCurrentUser();
            var result = await _customerService.DeleteAddress(currentUser, addressId);
            if (!result.Success)
            {
                return BadRequest(new { result = result, customer = currentUser });
            }
            return Ok(new { result = result, customer = currentUser });
        }
        #endregion
        private Task<StormyCustomer> GetCurrentUser()
        {
            return _identityService.GetUserByClaimPrincipal(User);
        }
        private string GenerateActionLink(string actionName, string token, string username)
        {
            string validationLink = null;
            if (this.Url != null)
            {
                validationLink = Url.Action(actionName, "Register",
                    new { Token = token, Username = username },
                    HttpContext.Request.Scheme);
            }

            return validationLink;
        }

    }
}
