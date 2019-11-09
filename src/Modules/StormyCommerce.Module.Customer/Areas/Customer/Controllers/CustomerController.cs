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
        private readonly ICustomerService _customerService;
        private readonly IUserIdentityService _identityService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService,IUserIdentityService identityService,IMapper mapper)
        {
            _customerService = customerService;
            _identityService = identityService;
            _mapper = mapper;
        }        
        [HttpPost("address/create")]
        [ValidateModel]
        public async Task<IActionResult> AddAddressAsync([FromBody]CustomerAddress address)
        {            
            var customer = await GetCurrentCustomer();                               
            await _customerService.AddCustomerAddressAsync(address,customer.Id);
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
            await _customerService.AddWishListItem(customer, productId);
            return Ok();
        }

        private async Task<StormyCustomer> GetCurrentCustomer()
        {
            return await _identityService.GetUserByClaimPrincipal(User);                       
        }
    }
}
