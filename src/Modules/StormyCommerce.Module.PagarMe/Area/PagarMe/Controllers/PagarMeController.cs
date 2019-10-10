using System.Collections.Generic;
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
        [HttpPost("charge")]
        [ValidateModel]
        [ValidateAntiForgeryToken]
        //TODO:Create a postback endpoint
        public async Task<IActionResult> Charge([FromBody]TransactionVm transactionVm)
        {             
            var result = await _pagarMeWrapper.Charge(transactionVm);
            if(!result.Success) return BadRequest($"A error occured in the payment process \n Error Object:{result}");

            // Transaction tr = new Transaction();
                                
            return Ok();
        }
        [HttpPost("charge_postback")]
        [ValidateModel]
        [ValidateAntiForgeryToken]
        public IActionResult ChargePostback([FromBody]PostBackModel model)
        {
            //TODO:Write new order,shipment and related to the database
            _pagarMeWrapper.CaptureTransaction(model.IdOrToken, model.Amount);
            return Ok();
        }
        [HttpPost("refund")]
        [ValidateModel]
        [ValidateAntiForgeryToken]
        public IActionResult Refund(string transactionId)
        {
            _pagarMeWrapper.RefundTransaction(transactionId);
            return Ok();
        }
        //TODO:Change to a internal domain model
        [HttpGet("list")]
        [ValidateModel]
        [ValidateAntiForgeryToken]
        [Authorize(Roles.Admin)]
        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await _pagarMeWrapper.GetAllTransactionAsync();
        }
        [HttpGet]
        [ValidateModel]
        [ValidateAntiForgeryToken]
        [Authorize(Roles.Admin)]
        public async Task<Transaction> GetTransactionById(string id)
        {
            return await _pagarMeWrapper.GetTransactionByIdAsync(id);
        }
    }
}
