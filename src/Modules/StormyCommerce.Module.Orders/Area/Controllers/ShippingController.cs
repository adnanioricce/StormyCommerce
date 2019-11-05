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
        [HttpPost("calcdelivery_fororder")]
        [ValidateModel]
        public async Task<ActionResult<List<DeliveryCalculationOptionResponse>>> CalculateDeliveryCost(DeliveryCalculationForOrderRequest model)
        {
            //TODO:Do a research about the sizes of clothes, different kinds of clothes will give different dimensions
            //TODO:Wrap all this in ShippingService
            var shipment = _shippingService.CalculateShipmentDimensions(_mapper.Map<StormyOrder>(model.Order));                                                
            var request = new DeliveryCalculationRequest{
                //TODO:Need to compare with all options of shipping
                ServiceCode = ServiceCode.PacAVista,
                FormatCode = FormatCode.CaixaOuPacote,
                Weight = shipment.TotalWeight < 0.3 ? 0.3m : (decimal)shipment.TotalWeight,
                Height = shipment.TotalHeight < 2 ? 2 : (decimal)shipment.CubeRoot,
                Width = shipment.TotalWidth < 11 ? 11 : (decimal)shipment.CubeRoot,
                Length = shipment.TotalLength < 16 ? 16 : (decimal)shipment.CubeRoot,   
                Diameter = (decimal)Math.Sqrt(Math.Pow(shipment.TotalLength,2) + Math.Pow(shipment.TotalWidth,2)),             
                DestinationPostalCode = model.DestinationPostalCode,
                ValorDeclarado = shipment.Order.TotalPrice / 100,
                WarningOfReceiving = "N",
            };                                     
            return Ok(new {result = await _correiosService.CalculateDeliveryPriceAndTime(_mapper.Map<CalcPrecoPrazoModel>(request)) });            
        }
    }
}
