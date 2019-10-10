using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagarMe;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using StormyCommerce.Module.PagarMe.Services;
using System;
using System.Threading.Tasks;
using System.Linq;

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
            //TODO:Get current customer instead
            var customer = await _customerService.GetCustomerByUserNameOrEmail("",boletoCheckoutViewModel.CustomerEmail);
            var transaction = boletoCheckoutViewModel.ToTransactionVm(customer);
            transaction.PostbackUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/api/Checkout/postback";
            transaction.Async = true;
            var result = await _pagarmeService.ChargeAsync(transaction);            

            if(!result.Success) return BadRequest($"failed on the payment charge process, see the error code for more info\n {result.Error}");            
            var price = transaction.Amount / 100;            
            var order = new StormyOrder{
                Customer = customer,
                DeliveryCost = transaction.Shipping.Fee, 
                DeliveryDate = Convert.ToDateTime(transaction.Shipping.DeliveryDate),
                PaymentMethod = "boleto",
                //TODO:maybe a value object for the price operations? they don't seem like a value type for me
                TotalPrice = price,                
                

            }
            await _orderService.CreateOrderAsync();
            

        }
    }
}
