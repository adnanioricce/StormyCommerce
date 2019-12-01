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
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

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
        private readonly IShippingService _shippingService;
        private readonly IAppLogger<CheckoutController> _logger;
        private readonly IMapper _mapper;
        public CheckoutController(
        IUserIdentityService userIdentityService,
        IPaymentProcessor paymentProcessor,
        IOrderService orderService,
        IProductService productService,
        IShippingService shippingService,
        IAppLogger<CheckoutController> logger,
        IMapper mapper)
        {                                
            _identityService = userIdentityService;                        
            _paymentProcessor = paymentProcessor;
            _orderService = orderService;
            _productService = productService;
            _shippingService = shippingService;
            _logger = logger;
            _mapper = mapper;
        }        
        [HttpPost("boleto")]
        [ValidateModel]    
        public async Task<ActionResult<BoletoCheckoutResponse>> BoletoCheckout([FromBody] Core.Models.Order.BoletoCheckoutRequest request)
        {            
            if(!(request.Items.Count > 0 && request.Items.All(i => i.Quantity > 0))) {
                return BadRequest(Result.Fail("You can't order a item with 0 products or create a order with 0 items",request));
            }
            var products = await _productService.GetProductsByIdsAsync(request.Items.Select(i => i.StormyProductId).ToArray());            
            if(!(request.Items.HasStockForOrderItems(products)))
            {
                return BadRequest(Result.Fail("looks like you have items on your order that ask for quantity that the store don't have on stock now",new {request,products}));
            }                        
            var user = await _identityService.GetUserByClaimPrincipal(User);
            var userDto = _mapper.Map<StormyCustomer, CustomerDto>(user);            
            var response = await _paymentProcessor.ProcessBoletoPayment(request,userDto);
            response.Order.StormyCustomerId = user.Id;            
            var createOrderResult = await _orderService.CreateOrderAsync(response.Order);
            if (!createOrderResult.Success)
            {
                _logger.LogError(createOrderResult.Error, createOrderResult);
                return BadRequest(createOrderResult);
            }
            var shipment = await _shippingService.PrepareShipment(new PrepareShipmentRequest { 
                Order = createOrderResult.Value,
                DestinationPostalCode = request.PostalCode,
                ShippingMethod = request.ShippingMethod,                
                TotalPrice = createOrderResult.Value.TotalPrice
            });
            shipment.DestinationAddressId = user.DefaultShippingAddress.Id;
            var shipmentResult = await _shippingService.CreateShipmentAsync(shipment);
            if (!shipmentResult.Success) {                
                _logger.LogError(shipmentResult.Error, shipmentResult);                
                return BadRequest(Result.Fail("Failed to add shipment to order. Exception was throwed when storing on database"));
            }
            var order = await _orderService.GetOrderByIdAsync(createOrderResult.Value.Id);
            return Ok(new BoletoCheckoutResponse {
               Order = order.Value,
               Payment = order.Value.Payment,
               Shipment = order.Value.Shipment                              
            });
        }
        [HttpPost("postback")]
        [ValidateModel]
        public async Task<IActionResult> CheckoutPostback(Postback postback)
        {
            return NoContent();
        }                        
    }        
}
