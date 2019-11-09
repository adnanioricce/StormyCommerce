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
using StormyCommerce.Module.Orders.Area.Models.Orders;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;                      
        private readonly IUserIdentityService _identityService;
        private readonly PagarMeWrapper _pagarmeService;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public CheckoutController(IOrderService orderService,         
        ILogger logger,
        PagarMeWrapper pagarMeService,
        IUserIdentityService userIdentityService,
        IMapper mapper)
        {
            _orderService = orderService;                        
            _logger = logger;
            _pagarmeService = pagarMeService;
            _identityService = userIdentityService;
            _mapper = mapper;
        }        
        [HttpPost("boleto")]
        [ValidateModel]                
        public async Task<IActionResult> CheckoutBoleto([FromBody]BoletoCheckoutRequest requestModel)
        {                             
            var customer = _identityService.GetUserByEmail(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "email").Value);            
            var transaction = _mapper.Map<TransactionVm>(requestModel);                                                
            transaction.PostbackUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/api/Checkout/postback";
            transaction.Async = true;                        
            transaction.Customer = _mapper.Map<PagarMeCustomerVm>(customer);
            var result = await _pagarmeService.ChargeAsync(transaction);                                    
            var order = _mapper.Map<StormyOrder>(transaction);            
            order.Payment.PaymentStatus = result.Success ? PaymentStatus.Pending : PaymentStatus.Failed;                        
            order.Status = OrderStatus.New;                                                                             
            //?I think you should do the inverse, receive a OrderDto and after that return a new OrderDto
            Result<OrderDto> orderDto = await _orderService.CreateOrderAsync(order);                
            _logger.LogInformation($"Order Created at {nameof(CheckoutBoleto)} in {nameof(CheckoutController)}");
            return Ok(new BoletoCheckoutResponse{
                Result = orderDto,
                BoletoUrl = transaction.BoletoUrl,
                BoletoBarcode = transaction.BoletoBarcode
            });                        
        }
        [HttpPost("postback")]
        [ValidateModel]
        public async Task<IActionResult> CheckoutPostback()
        {
            return NoContent();
        }        
    }    
}
