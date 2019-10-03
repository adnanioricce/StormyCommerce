using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagarMe;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using System;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;        
        private readonly ILogger _logger;

        public CheckoutController(IOrderService orderService, IPaymentService paymentService, ILogger logger)
        {
            _orderService = orderService;            
            _paymentService = paymentService;
            _logger = logger;
        }

        ///<summary>
        /// Nothing working yet
        ///</summary>
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Checkout([FromBody]CheckoutOrderVm checkoutVm)
        {                        
            return BadRequest("Method Not implemented");
        }
    }
}
