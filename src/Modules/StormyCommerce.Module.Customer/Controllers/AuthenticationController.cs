using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Controllers;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Interfaces;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Controllers
{
    public class AuthenticationController : BaseApiController
    {
        private IUserIdentityService _identityService;
        private IEmailSender _emailSender;        
        public AuthenticationController(IUserIdentityService identityService,IEmailSender emailSender)
        {
            _identityService = identityService;
            _emailSender = emailSender;
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync()
        {
            return Ok();
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync()
        {
            return Ok();
        }        
    }
}
