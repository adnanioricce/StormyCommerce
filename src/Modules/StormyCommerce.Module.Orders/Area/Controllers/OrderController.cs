using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
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

        //TODO:Add the payment Service
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("/create")]
        [ValidateModel]
        public async Task CreateOrder([FromBody] OrderDto orderDto)
        {
            //_orderService.CreateOrderAsync(orderDto);
        }
    }
}
