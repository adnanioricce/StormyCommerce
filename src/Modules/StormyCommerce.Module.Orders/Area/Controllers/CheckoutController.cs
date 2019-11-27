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
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Order.Response;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Interfaces.Domain.Payments;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Extensions;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    [EnableCors("Default")]
    public class CheckoutController : Controller
    {        
        private readonly IUserIdentityService _identityService;        
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;        
        public CheckoutController(
        IUserIdentityService userIdentityService,        
        IPaymentProcessor paymentProcessor,        
        IOrderService orderService,
        IProductService productService,
        IMapper mapper)
        {                                
            _identityService = userIdentityService;                        
            _paymentProcessor = paymentProcessor;
            _orderService = orderService;
            _productService = productService;
            _mapper = mapper;
        }        
        [HttpPost("boleto")]
        [ValidateModel]    
        public async Task<ActionResult<BoletoCheckoutResponse>> SimpleCheckoutBoleto([FromBody]SimpleBoletoCheckoutRequest request)
        {            
            if(!(request.Items.Count > 0 && request.Items.All(i => i.Quantity > 0))) {
                return BadRequest(Result.Fail("You can't order a item with 0 products or create a order with 0 items",request));
            }
            var products = await _productService.GetProductsByIdsAsync(request.Items.Select(i => i.StormyProductId).ToArray());
            if(!(request.Items.HasStockForOrderItems(products)))
            {
                return BadRequest(Result.Fail("looks like you have items on your order that ask for quantity that the store don't have on stock now"));
            }                        
            var user = await _identityService.GetUserByClaimPrincipal(User);
            var userDto = _mapper.Map<StormyCustomer, CustomerDto>(user);            
            var response = await _paymentProcessor.ProcessBoletoPayment(request,userDto);
            response.Order.StormyCustomerId = user.Id;            
            var result = await _orderService.CreateOrderAsync(response.Order);            
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
        //private List<OrderItemDto> Map
    }        
}
