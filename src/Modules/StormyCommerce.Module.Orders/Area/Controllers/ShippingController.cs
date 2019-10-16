using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
using AutoMapper;
using System.Collections.Generic;
using StormyCommerce.Module.Orders.Area.Models;
using System.Linq;
// using StormyCommerce.Module.Shipping.Models;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly CorreiosService _correiosService;        
        private readonly IMapper _mapper;
        public ShippingController(CorreiosService correiosService,IMapper mapper)
        {
            _correiosService = correiosService;            
            _mapper = mapper;
        }
        [HttpPost("calcdelivery")]
        [ValidateModel]
        public async Task<ActionResult<List<DeliveryCalculationOptionResponse>>> CalculateDeliveryCost(CalcPrecoPrazoModel model) {                        
            return Ok(new { result = await _correiosService.CalculateDeliveryPriceAndTime(_mapper.Map<CalcPrecoPrazoModel>(model)) });
        }       
    }
}
