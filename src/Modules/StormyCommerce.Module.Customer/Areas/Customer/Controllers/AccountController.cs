using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
        private readonly IAppLogger<AuthenticationController> _logger;
        private readonly IMapper _mapper;
        public AccountController(IUserIdentityService identityService,IAppLogger<AuthenticationController> logger,IMapper mapper)
        {
            _identityService = identityService;                    
            _logger = logger;
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
            await _identityService.EditUserAsync(appUser);            
            return Ok(new { Message = $"Email confirmation performed With Success at {DateTimeOffset.UtcNow}" });            
        }

        [HttpPost("reset_password")]
        [ValidateModel]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordViewModel model)
        {
            var user = _identityService.GetUserByEmail(model.Email);

            if (user == null) return BadRequest();
            var result = await _identityService.ResetPasswordAsync(user, model.Code, model.Password);

            if (!result.Succeeded) return BadRequest();

            return Ok();
        }     
        [HttpPost("add_shipping_address")]
        [Authorize(Roles.Customer)]
        [ValidateModel]
        //TODO:Duplicated Logic, too much ifs, refactor this
        public async Task<IActionResult> AddDefaultShippingAddress([FromBody]CreateShippingAddressRequest model)
        {
            var user = await GetCurrentUser();
            if (!model.IsBillingAddress)
            {
                if (user.DefaultShippingAddress == null)
                {
                    user.DefaultShippingAddress = new CustomerAddress
                    {
                        Address = model.Address,
                        Owner = user,
                        WhoReceives = string.IsNullOrEmpty(model.WhoReceives) ? user.FullName : model.WhoReceives
                    };
                    var result = await _identityService.EditUserAsync(user);
                    if (!result.Success) return BadRequest(result);
                    return Ok(new
                    {
                        message = "address added with success",
                        result = result
                    });
                }
                user.DefaultShippingAddress.Address = model.Address;
                await _identityService.EditUserAsync(user);
                return Ok(Result.Ok("address updated with success"));
            }
            if(user.DefaultBillingAddress == null)
            {
                user.DefaultBillingAddress = new CustomerAddress
                {
                    Address = model.Address,
                    Owner = user,
                    WhoReceives = string.IsNullOrEmpty(model.WhoReceives) ? user.FullName : model.WhoReceives
                };
                var result = await _identityService.EditUserAsync(user);
                if (!result.Success) return BadRequest(result);
                return Ok(new
                {
                    message = "address added with success",
                    result = result
                });                
            }
            user.DefaultBillingAddress.Address = model.Address;
            await _identityService.EditUserAsync(user);
            return Ok(Result.Ok("address updated with success"));
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
            _mapper.Map<EditCustomerAddressRequest, CustomerAddress>(request, currentUser.DefaultShippingAddress);
            var result = await _identityService.EditUserAsync(currentUser);
            if (!result.Success) return BadRequest(result);
            return Ok(new
            {
                message = "shipping address edited with success",
                result = result
            });
        }
        
        [HttpGet("get_current_user")]
        [Authorize(Roles.Customer)]
        public async Task<CustomerDto> GetCurrentCustomer()
        {            
            return _mapper.Map<StormyCustomer,CustomerDto>(await GetCurrentUser());
        }          
        private Task<StormyCustomer> GetCurrentUser()
        {
            return _identityService.GetUserByClaimPrincipal(User);
        }

    }
}
