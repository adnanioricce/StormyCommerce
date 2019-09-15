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
        public PagarMeController(PagarMeWrapper pagarMeWrapper,IStormyRepository<Payment> paymentRepository,IMapper mapper)
        {
            _pagarMeWrapper = pagarMeWrapper;
            _paymentRepository = paymentRepository;
            _mapper = mapper;                        
        }
        [HttpPost("/boleto")]
        [ValidateModel]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckoutBoleto([FromBody]TransactionVm transactionVm)
        {
            var transaction = _mapper.Map<TransactionVm, Transaction>(transactionVm);
            var payment = _mapper.Map<Payment>(transactionVm);
            var shipping = _mapper.Map<Shipment>(transactionVm);
            await _shipmentRepository.AddAsync(shipping);
            payment.PaymentStatus = PaymentStatus.Pending;
            await _paymentRepository.AddAsync(payment);
            transaction.Save();                        
            return Ok();
        }
    }
}
