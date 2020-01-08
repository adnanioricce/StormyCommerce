using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Areas.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles = Roles.Customer)]
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
        public IList<User> GetCustomersAsync()
        {
            return _identityService.GetUserManager().Users.ToList();
        }                                    
        private async Task<User> GetCurrentCustomer()
        {
            return await _identityService.GetUserByClaimPrincipal(User);                       
        }
    }
}
