using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
