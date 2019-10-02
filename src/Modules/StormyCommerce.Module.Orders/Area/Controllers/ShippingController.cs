using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayRequests;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Services;
// using StormyCommerce.Module.Shipping.Models;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly CorreiosService _correiosService;        
        public ShippingController(CorreiosService correiosService)
        {
            _correiosService = correiosService;            
        }
        [HttpPost("calcdelivery")]
        [ValidateModel]
        public async Task<ActionResult<cResultado>> CalculateDeliveryCost(CalculateShippingModel model){            
            cResultado response = await _correiosService.CalculateDeliveryPriceAndTime(model);                        
            return Ok(new { result = response });
        }       
    }
}
