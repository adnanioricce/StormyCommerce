using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
using AutoMapper;
using System.Collections.Generic;
using StormyCommerce.Module.Orders.Area.Models;
using System.Linq;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Module.Orders.Area.Models.Shipping;
using StormyCommerce.Core.Models;
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
            int itemsCount = 0; 
            double weight = 0;
            decimal totalPrice = 0;
            model.Items.ForEach(item => {
                itemsCount += item.Quantity;
                weight += item.Product.UnitWeight * item.Quantity;
                totalPrice += item.Price.GetPriceValueInDecimal();
            });            
            var request = new DeliveryCalculationRequest{
                //TODO:Need to compare with all options of shipping
                ServiceCode = ServiceCode.PacAVista,
                FormatCode = FormatCode.CaixaOuPacote,
                Weight = (int)weight,
                ValorDeclarado = totalPrice / 100,
                WarningOfReceiving = "N",
            };                         
            if(itemsCount <= 5){
                request.Width = 15; 
                request.Height = 3; 
                request.Length = 11;
            } else if(itemsCount <= 15 && itemsCount > 5){
                request.Width = 20; 
                request.Height = 7; 
                request.Length = 11; 
            } else if(itemsCount <= 30 && itemsCount > 15){
                request.Width = 25; 
                request.Height = 11; 
                request.Length = 15; 
            }
            return Ok(new {result = await _correiosService.CalculateDeliveryPriceAndTime(_mapper.Map<CalcPrecoPrazoModel>(request)) });            
        }
    }
}
