using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagarMe;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using StormyCommerce.Module.PagarMe.Services;
using System;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;        
        private readonly PagarMeWrapper _pagarmeService;
        private readonly ICustomerService _customerService;
        private readonly ILogger _logger;

        public CheckoutController(IOrderService orderService, 
        IPaymentService paymentService, 
        ILogger logger,
        PagarMeWrapper pagarMeService,
        ICustomerService customerService)
        {
            _orderService = orderService;            
            _paymentService = paymentService;
            _logger = logger;
            _pagarmeService = pagarMeService;
            _customerService = customerService;
        }

        ///<summary>
        /// Nothing working yet
        ///</summary>
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Checkout([FromBody]CheckoutOrderVm checkoutVm)
        {                        
            throw new NotImplementedException();
        }
        [HttpPost("boleto")]
        [ValidateModel]        
        public async Task<IActionResult> CheckoutBoleto([FromBody]BoletoCheckoutViewModel boletoCheckoutViewModel)
        {
            var customer = await _customerService.GetCustomerByUserNameOrEmail("",boletoCheckoutViewModel.CustomerEmail);
            throw new NotImplementedException();
        }
    }
}
