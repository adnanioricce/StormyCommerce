using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Areas.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles.Customer)]
    //[ValidateAntiForgeryToken]
    [EnableCors("Default")]
    public class CustomerController : Controller
    {        
        private readonly IUserIdentityService _identityService;
        private readonly IMapper _mapper;

        public CustomerController(IUserIdentityService identityService,IMapper mapper)
        {            
            _identityService = identityService;
            _mapper = mapper;
        }        
        [HttpPost("address/create")]
        [ValidateModel]
        public async Task<IActionResult> AddAddressAsync([FromBody]CustomerAddress address)
        {            
            var customer = await GetCurrentCustomer();                                           
            return Ok();
        }        
        [HttpGet("list")]
        [Authorize(Roles.Admin)]
        [ValidateModel]
        public IList<StormyCustomer> GetCustomersAsync()
        {
            return _identityService.GetUserManager().Users.ToList();
        }                      
        [HttpPost("add_wishlistitem")]     
        [ValidateModel]
        public async Task<IActionResult> AddItemToWishList(long productId)
        {
            var customer = await GetCurrentCustomer();            
            return Ok();
        }
        [HttpGet("get_currentuser")]
        [ValidateModel]
        [Roles(Roles.Customer,Roles.Guest)]
        public CustomerDto GetCustomerByEmail()
        {
            var user = _identityService.GetUserById(HttpContext.User.Claims.FirstOrDefault(c => string.Equals(c.Type,"sub"))?.Value);
            return _mapper.Map<StormyCustomer,CustomerDto>(_identityService.GetUserById(HttpContext.User.FindFirst(c => string.Equals(c.Type,"sub")).Value));
        }
        private async Task<StormyCustomer> GetCurrentCustomer()
        {
            return await _identityService.GetUserByClaimPrincipal(User);                       
        }
    }
}
