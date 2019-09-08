using System;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.Controllers
{
    [Area("PagarMe")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize]
    public class PagarMeController : Controller
    {
        public PagarMeController()
        {
            
        }
    }
}
