using AutoMapper;
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
using StormyCommerce.Module.Customer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Area.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles.Customer)]
    [EnableCors]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService,IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpPost("/address/create")]
        [ValidateModel]
        public async Task<IActionResult> AddAddressAsync([FromBody]Address address)
        {
            //TODO:Write method to get current request user
            //this.HttpContext.User.Identity.Name
            await _customerService.AddCustomerAddressAsync(address, 0);
            return new OkObjectResult(Result.Ok());
        }
        [HttpPost("/review")]
        [ValidateModel]        
        public async Task<IActionResult> WriteReviewAsync([FromBody]CustomerReviewDto review)
        {
            await _customerService.CreateCustomerReviewAsync(_mapper.Map<Review>(review),review.Email.ToUpper());
            return Ok();
        }
        [HttpPost("/admin")]
        [Authorize(Roles.Admin)]
        [ValidateModel]
        public async Task<IList<StormyCustomer>> GetCustomersAsync(int minLimit, long maxLimit)
        {
            return await _customerService.GetAllCustomersAsync(minLimit,maxLimit);
        }
        [HttpGet("/get")]
        [ValidateModel]
        public async Task<ActionResult<CustomerDto>> GetCustomerByEmailOrUsernameAsync(string email,string username)
        {
            return _mapper.Map<StormyCustomer,CustomerDto>(await _customerService.GetCustomerByUserNameOrEmail(email, username));
        }
        [HttpPost("/create")]
        [ValidateModel]
        public async Task<IActionResult> CreateCustomerAsync([FromBody]CustomerDto customerDto)
        {            
            var customer = await _customerService.GetCustomerByUserNameOrEmail(customerDto.UserName, customerDto.Email);

            if (customer != null) return BadRequest("Given Email or Username already exists");                

            if (customerDto == null) return BadRequest("given request is null");

            customer = _mapper.Map<CustomerDto, StormyCustomer>(customerDto);

            if (customer == null) return BadRequest("failed to map given customer");

            await _customerService.CreateCustomerAsync(customerDto);
            return Ok();
        }

        // public async Task<IActionResult> CreateUserReview()
        // [HttpPo]
    }
}
