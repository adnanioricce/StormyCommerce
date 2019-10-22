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
using AutoMapper;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
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
        private readonly ICustomerService _customerService;
        private readonly CorreiosService _correiosService;
        private readonly IShippingService _shippingService;
        private readonly PagarMeWrapper _pagarmeService;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public CheckoutController(IOrderService orderService, 
        IPaymentService paymentService,
        IShippingService shippingService, 
        ILogger logger,
        PagarMeWrapper pagarMeService,
        ICustomerService customerService,
        IMapper mapper)
        {
            _orderService = orderService;            
            _paymentService = paymentService;
            _shippingService = shippingService;
            _logger = logger;
            _pagarmeService = pagarMeService;
            _customerService = customerService;
            _mapper = mapper;
        }        
        [HttpPost("boleto")]
        [ValidateModel]                
        public async Task<IActionResult> CheckoutBoleto([FromBody]BoletoCheckoutViewModel boletoCheckoutViewModel)
        {                                    
            var customer = await _customerService.GetCustomerByUserNameOrEmail("",HttpContext.User.Claims.FirstOrDefault(c => c.Type == "email").Value);
            var transaction = boletoCheckoutViewModel.ToTransactionVm(customer);            
            transaction.PostbackUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/api/Checkout/postback";
            transaction.Async = true;                        
            var result = await _pagarmeService.ChargeAsync(transaction);                                    
            var order = _mapper.Map<StormyOrder>(transaction);
            order.Payment.PaymentStatus = result.Success ? PaymentStatus.Pending : PaymentStatus.Failed;                        
            order.Status = OrderStatus.New;                                                                 
            return Ok(await _orderService.CreateOrderAsync(order));            
        }
        
    }    
}
