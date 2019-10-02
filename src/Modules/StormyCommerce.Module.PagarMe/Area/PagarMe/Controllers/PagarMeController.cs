using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PagarMe;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Infraestructure.Interfaces;
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
        private readonly IStormyRepository<Payment> _paymentRepository;
        private readonly IStormyRepository<Shipment> _shipmentRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        public PagarMeController(PagarMeWrapper pagarMeWrapper,
        IStormyRepository<Payment> paymentRepository,
        IMapper mapper,
        IEmailSender emailSender)
        {
            _pagarMeWrapper = pagarMeWrapper;
            _paymentRepository = paymentRepository;
            _mapper = mapper;                      
            _emailSender = emailSender;  
        }
        [HttpPost("charge/boleto")]
        [ValidateModel]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Charge([FromBody]TransactionVm transactionVm)
        {           
            return Ok(await _pagarMeWrapper.Charge(transactionVm));
        }        
    }
}
