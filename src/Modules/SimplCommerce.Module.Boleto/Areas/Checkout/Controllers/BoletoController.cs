using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Interfaces.Domain.Order;

namespace SimplCommerce.Module.Boleto.Areas.Boleto.Controllers
{
    [Area("Checkout")]
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class BoletoController : Controller
    {
        private readonly BoletoService _boletoService;
        private readonly IOrderService _orderService;
        public BoletoController(BoletoService boletoService,IOrderService orderService)
        {
            _boletoService = boletoService;
            _orderService = orderService;
        }
    }
}
