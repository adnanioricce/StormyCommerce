using System;
using Microsoft.AspNetCore.Mvc;

namespace StormyCommerce.Module.Shipping.Area.Shipping.Controllers
{
    [Area("Shipping")]
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : Controller
    {       
        [HttpGet("getmessage")] 
        public string Message()
        {
            return "is working";
        }
    }
}
