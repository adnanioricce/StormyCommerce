using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Payment;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Services.Orders;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckoutController : Controller
    {        
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        public CheckoutController(IOrderService orderService,IPaymentService paymentService,IShippingService shippingService)
        {
            _orderService = orderService;
            _paymentService = paymentService;
            _shippingService = shippingService;
        }
        [HttpPost("checkout/boleto")]
        [ValidateModel]
        public async Task<IActionResult> CheckoutBoleto([FromBody]BoletoCheckoutViewModel checkoutVm)
        {
            //TODO:Implement
            return NoContent();
        }
        
    }    
}
