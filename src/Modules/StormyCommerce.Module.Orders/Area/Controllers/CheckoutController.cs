using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PagarMe;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using System;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Customer;
using PagarMe.Model;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Module.Orders.Services;
using Microsoft.AspNetCore.Cors;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    [EnableCors("Default")]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserIdentityService _identityService;                      
        private readonly IMapper _mapper;
        private readonly PagarMeWrapper _pagarMeWrapper;
        public CheckoutController(
        IUserIdentityService userIdentityService,
        IOrderService orderService,        
        PagarMeWrapper pagarMeWrapper,
        IMapper mapper)
        {                                
            _identityService = userIdentityService;            
            _orderService = orderService;
            _pagarMeWrapper = pagarMeWrapper;
            _mapper = mapper;
        }        
        [HttpPost("boleto")]
        [ValidateModel]    
        public async Task<ActionResult<BoletoCheckoutResponse>> SimpleCheckoutBoleto([FromBody]SimpleBoletoCheckoutRequest request)
        {
            var user = await _identityService.GetUserByClaimPrincipal(User);
            var transaction = _pagarMeWrapper.CreateSimpleBoletoTransaction(request, user);
            var result = _pagarMeWrapper.Charge(transaction);
            if (!result.Success) return BadRequest(result);
            
            return Ok(result);
        }
        [HttpPost("postback")]
        [ValidateModel]
        public async Task<IActionResult> CheckoutPostback(Postback postback)
        {
            return NoContent();
        }        

        private Shipment CreateShipment(Dictionary<long,StormyProduct> products,BoletoCheckoutRequest requestModel)
        {
            
            double weight = requestModel.Items.Sum(it => products.GetValueOrDefault(it.ProductId).UnitWeight * it.Quantity);
            double totalHeight = 0;
            double totalWidth = 0;
            double totalLength = 0;
            double shipmentArea = requestModel.Items.Sum(it => {
                var product = products.GetValueOrDefault(it.ProductId);
                totalHeight += product.Height;
                totalWidth += product.Width;
                totalLength += product.Length;
                return product.CalculateDimensions() * it.Quantity;
                });
            double cubeRoot = Math.Ceiling(Math.Pow(shipmentArea, (double)1 / 3));
            return new Shipment
            {
                TotalWeight = weight,
                TotalArea = shipmentArea,
                TotalHeight = totalHeight < 2 ? 2 : cubeRoot,
                TotalWidth = totalWidth < 16 ? 16 : cubeRoot,
                TotalLength = totalLength < 11 ? 11 : cubeRoot,
                CubeRoot = cubeRoot,                
            };
        }
        
    }        
}
