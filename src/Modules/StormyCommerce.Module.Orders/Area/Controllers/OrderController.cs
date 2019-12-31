using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;

using StormyCommerce.Core.Models;
 
using StormyCommerce.Infraestructure.Interfaces;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    [EnableCors("Default")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IUserIdentityService _identityService;
        
        public OrderController(IOrderService orderService, IUserIdentityService identityService)
        {
            _orderService = orderService;
            _identityService = identityService;
        }
        [HttpGet("list")]
        [ValidateModel]
        public async Task<List<OrderDto>> GetAllOrders()
        {
            var currentUser = await _identityService.GetUserByClaimPrincipal(this.User);
            return await _orderService.GetAllOrdersFromCustomer(currentUser.Id);
        }
        [HttpGet("get")]
        [ValidateModel]
        public async Task<ActionResult<OrderDto>> GetOrderByKey(Guid key)
        {
            var currentUser = await _identityService.GetUserByClaimPrincipal(this.User);
            var order = await _orderService.GetOrderByUniqueIdAsync(key);
            if(!(order.UserId == currentUser.Id)){
                return BadRequest(Result.Fail("you don't have permission to see this order"));
            }
            return new OrderDto(order);
        }
        [HttpPut("cancel")]
        [ValidateModel]
        public async Task<IActionResult> CancelOrderByKey([FromBody]Guid key)
        {
            var order = await _orderService.GetOrderByUniqueIdAsync(key);
            var result = await _orderService.CancelOrderAsync(order.Value.Id);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
    }
}
