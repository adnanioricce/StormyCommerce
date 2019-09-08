using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Module.Customer.Area.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles.Customer)]
    [EnableCors]
    public class AccountController
    {
        private ICustomerService _customerService;

        public AccountController(ICustomerService customerService)
        {
            _customerService = customerService;
        }        
        [HttpPost("/address")]        
        [ValidateModel]
        public async Task<IActionResult> AddAddressAsync([FromBody]Address address)
        {
            await _customerService.AddCustomerAddressAsync(address);
            return new OkObjectResult(Result.Ok());
        }
        // [HttpPo]

    }
}