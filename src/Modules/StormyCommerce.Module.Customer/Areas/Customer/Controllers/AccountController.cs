﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models;
using System;
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
        public AccountController(IUserIdentityService identityService,IAppLogger<AuthenticationController> logger)
        {
            _identityService = identityService;                    
            _logger = logger;
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
