﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Areas.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    //[ValidateAntiForgeryToken]
    [EnableCors("Default")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IUserIdentityService _identityService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService,IUserIdentityService identityService,IMapper mapper)
        {
            _customerService = customerService;
            _identityService = identityService;
            _mapper = mapper;
        }
        //public async Task<StormyCustomer> GetCustomerByEmail()
        //{
        //}
        [HttpPost("address/create")]
        [ValidateModel]
        public async Task<IActionResult> AddAddressAsync([FromBody]CustomerAddress address)
        {            
            var customer = GetCurrentCustomer();                               
            await _customerService.AddCustomerAddressAsync(address,customer.Id);
            return Ok();
        }        
        [HttpGet("list")]
        [Authorize("Admin")]
        [ValidateModel]
        public async Task<IList<StormyCustomer>> GetCustomersAsync(int minLimit, long maxLimit)
        {
            return await _customerService.GetAllCustomersAsync(minLimit,maxLimit);
        }
        [HttpGet("getbyemail")]
        [ValidateModel]
        public async Task<ActionResult<CustomerDto>> GetCustomerByEmailOrUsernameAsync(string email,string username)
        {
            return _mapper.Map<CustomerDto>(await _customerService.GetCustomerByUserNameOrEmail(email, username));
        }
        [HttpPost("createcustomer")]
        [AllowAnonymous]
        [ValidateModel]
        public async Task<IActionResult> CreateCustomerAsync([FromBody]CreateCustomerRequest model)
        {                        
            var customer = await _customerService.GetCustomerByUserNameOrEmail(model.UserName, model.Email);
            if (customer != null) return BadRequest("Given Email or Username already exists");                
            customer = _mapper.Map<CreateCustomerRequest, StormyCustomer>(model);
            if (customer == null) return BadRequest("failed to map given customer");

            await _customerService.CreateCustomerAsync(customer);
            return Ok();
        }
        [HttpPost("edit")]
        [ValidateModel]        
        public async Task<IActionResult> EditCustomerAsync([FromBody]CustomerDto customerDto)
        {
            var customer = await _customerService.GetCustomerByUserNameOrEmail(customerDto.UserName,customerDto.Email);
            if(customer == null) return NotFound("Customer was not found");
            await _customerService.EditCustomerAsync(customerDto);
            return Ok();
        }

        private async Task<StormyCustomer> GetCurrentCustomer()
        {
            var user = await _identityService.GetUserByClaimPrincipal(User);           
            return await _customerService.GetCustomerByUserNameOrEmail(user.NormalizedUserName,user.NormalizedEmail);  
        }
    }
}
