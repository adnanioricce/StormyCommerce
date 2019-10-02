using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using System;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    [Authorize]
    public class OrderController
    {
        private readonly IOrderService _orderService;
        private readonly IAppLogger<OrderController> _logger;
        private readonly IShippingService _shippingService;
        private readonly IPaymentService _paymentService;
        public OrderController(IOrderService orderService,
        IAppLogger<OrderController> logger,
        IShippingService shippingService)
        {
            _orderService = orderService;
            _logger = logger;
            _shippingService = shippingService;
        }

        [HttpPost("/create")]
        [ValidateModel]
        public async Task CreateOrder([FromBody]OrderDto orderDto)
        {
            throw new NotImplementedException();
            //_orderService.CreateOrderAsync(orderDto);
        }
    }
}
