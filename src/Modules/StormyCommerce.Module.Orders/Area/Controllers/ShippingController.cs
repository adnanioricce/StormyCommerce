using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
using AutoMapper;
using System.Collections.Generic;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Area.Models.Shipping;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using System;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Core.Models.Shipment.Response;
using StormyCommerce.Core.Models.Shipment.Request;
// using StormyCommerce.Module.Shipping.Models;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly CorreiosService _correiosService;                
        private readonly IShippingService _shippingService;
        private readonly IMapper _mapper;
        public ShippingController(CorreiosService correiosService,IShippingService shippingService,IMapper mapper)
        {
            _correiosService = correiosService;                        
            _shippingService = shippingService;
            _mapper = mapper;
        }
        [HttpPost("calcdelivery")]
        [ValidateModel]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<DeliveryCalculationOptionResponse>>> CalculateDeliveryCost(DeliveryCalculationRequest model) 
        {                                      
            return Ok(Result.Ok(await _correiosService.CalculateDeliveryPriceAndTime(_mapper.Map<DeliveryCalculationRequest,CalcPrecoPrazoModel>(model))));
        }                                      
    }
}
