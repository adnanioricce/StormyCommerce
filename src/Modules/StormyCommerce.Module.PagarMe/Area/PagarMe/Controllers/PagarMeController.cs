using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using StormyCommerce.Module.PagarMe.Services;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.Controllers
{
    [Area("PagarMe")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles.Customer)]
    [EnableCors("Default")]
    public class PagarMeController : Controller
    {
        private readonly PagarMeWrapper _pagarMeWrapper;
        private readonly IPaymentService _paymentService;
        // private readonly IMapper _mapper;
        public PagarMeController(PagarMeWrapper pagarMeWrapper,IPaymentService paymentService)
        {
            _pagarMeWrapper = pagarMeWrapper;
            _paymentService = paymentService;
        }
        [HttpPost("/boleto")]
        public async Task<IActionResult> CheckoutBoleto([FromBody]TransactionVm transactionVm)
        {           
            // var transaction = _mapper.
            return Ok();
        }
    }
}
