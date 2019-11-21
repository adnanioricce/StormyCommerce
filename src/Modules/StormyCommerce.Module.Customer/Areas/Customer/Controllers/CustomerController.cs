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
        [HttpGet("list")]
        [Authorize(Roles.Admin)]
        [ValidateModel]
        public IList<StormyCustomer> GetCustomersAsync()
        {
            return _identityService.GetUserManager().Users.ToList();
        }                                    
        private async Task<StormyCustomer> GetCurrentCustomer()
        {
            return await _identityService.GetUserByClaimPrincipal(User);                       
        }
    }
}
