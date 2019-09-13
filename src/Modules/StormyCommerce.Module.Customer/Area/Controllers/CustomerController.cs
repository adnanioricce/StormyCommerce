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
        private ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService,IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpPost("/address")]
        [ValidateModel]
        public async Task<IActionResult> AddAddressAsync([FromBody]Address address)
        {
            //TODO:Write method to get current request user
            //this.HttpContext.User.Identity.Name
            await _customerService.AddCustomerAddressAsync(address, 0);
            return new OkObjectResult(Result.Ok());
        }

        public async Task<IActionResult> WriteReviewAsync(CustomerReviewDto review)
        {
            await _customerService.CreateCustomerReviewAsync(_mapper.Map<Review>(review));
        }

        public Task<IList<StormyCustomer>> GetCustomers(int minLimit, long maxLimit)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<CustomerDto>> GetCustomerByEmail(string email)
        {
            throw new NotImplementedException();
        }

        // public async Task<IActionResult> CreateUserReview()
        // [HttpPo]
    }
}
