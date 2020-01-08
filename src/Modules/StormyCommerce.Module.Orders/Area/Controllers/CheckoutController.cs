﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Entities.Customer;
using PagarMe.Model;
using StormyCommerce.Infraestructure.Interfaces;
using Microsoft.AspNetCore.Cors;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Module.Payments.Interfaces;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Catalog.Interfaces;
using SimplCommerce.Module.Orders.Models;
using StormyCommerce.Module.Payments.Models.Requests;
using StormyCommerce.Module.Orders.Models.Responses;
using StormyCommerce.Module.Orders.Models.Dtos;
using SimplCommerce.Module.Orders.Models.Responses;
using SimplCommerce.Module.Shipments.Interfaces;
using SimplCommerce.Module.Shipments.Requests;
using SimplCommerce.Module.Shipments.Models.Dtos;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles = Roles.Customer + ", " + Roles.Guest)]
    [EnableCors("Default")]
    public class CheckoutController : Controller
    {        
        private readonly IUserIdentityService _identityService;        
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IShippingService _shippingService;
        private readonly IAppLogger<CheckoutController> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;
        public CheckoutController(
        IUserIdentityService userIdentityService,
        IPaymentProcessor paymentProcessor,
        IOrderService orderService,
        IProductService productService,
        IShippingService shippingService,
        IAppLogger<CheckoutController> logger,
        IEmailSender emailSender,
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
        public async Task<ActionResult<CheckoutResponse>> BoletoCheckout([FromBody] CheckoutBoletoRequest request)
        {            
            var checkResult = await CheckIfItemIsOnStock(request);
            if (!checkResult.Success) return BadRequest(checkResult);                                 
            var user = await _identityService.GetUserByClaimPrincipal(User);
            var userDto = _mapper.Map<User, CustomerDto>(user);            
            var result = await CreateOrderForCheckout(request, userDto, user.Id);
            if (!result.Success)
            {
                _logger.LogError(result.Message, result);
                return BadRequest(result);
            }
            var shipmentCreateResult = await CreateShipmentForOrder(result,request,userDto);
            if (!shipmentCreateResult.Success) {                
                _logger.LogError(shipmentCreateResult.Message, shipmentCreateResult);                
                return BadRequest(Result.Fail("Failed to add shipment to order. Exception was throwed when storing on database"));
            }
            var order = await _orderService.GetOrderByIdAsync(result.Value.Id);            
            return Ok(new CheckoutResponse(order.Value));
        }
        [HttpPost("credit_card")]
        [ValidateModel]
        public async Task<ActionResult<CreditCardCheckoutResponse>> CreditCardCheckout([FromBody] CheckoutCreditCardRequest request)
        {
            var user = await _identityService.GetUserByClaimPrincipal(User);
            var userDto = _mapper.Map<User, CustomerDto>(user);
            //var order = BuildOrderForCreditCardCheckout(request);
            var order = new Order();
            var createOrderResult = await _orderService.CreateOrderAsync(order);
            var shipment = await _shippingService.PrepareShipment(new PrepareShipmentRequest(createOrderResult.Value, request.PostalCode, request.ShippingMethod));
            shipment.DestinationAddressId = userDto.Addresses.FirstOrDefault(u => u.IsDefault && u.Type == AddressType.Shipping).Id;
            var shipmentResult = await _shippingService.CreateShipmentAsync(shipment);            
            var orderDto = await _orderService.GetOrderByIdAsync(createOrderResult.Value.Id);
            var response = await _paymentProcessor.ProcessCreditCardPaymentAsync(request,userDto);
            if (!response.Result.Success) return BadRequest(response.Result);            
            return Ok(new CreditCardCheckoutResponse { 
                //Payment = response.
                //Order = orderDto.Value,
                Shipment = new ShipmentDto(shipment)
            });
        }
        [HttpPost("postback")]
        [ValidateModel]
        public async Task<IActionResult> CheckoutPostback(Postback postback)
        {
            return NoContent();
        }   
        //private Order BuildOrderForCreditCardCheckout(CheckoutCreditCardRequest request)
        //{            
        //    return new Order
        //    {
        //        Payment = new Core.Entities.Payments.StormyPayment
        //        {
        //            Amount = request.Amount,
        //            PaymentMethod = Core.Entities.Payments.PaymentMethod.CreditCard,
        //            CreatedOn = DateTimeOffset.UtcNow,
        //            PaymentStatus = Core.Entities.Payments.PaymentStatus.Processing,                    
        //        }
        //    };
        //}
        private async Task<Result<OrderDto>> CreateOrderForCheckout(CheckoutBoletoRequest request,CustomerDto userDto,long userId)
        {
            ProcessPaymentResponse response = await _paymentProcessor.ProcessBoletoPaymentRequestAsync(request, userDto);
            response.Order.CreatedById = userId;
            var createOrderResult = await _orderService.CreateOrderAsync(response.Order);            
            return createOrderResult;
        }
        private async Task<Result> CreateShipmentForOrder(Result<OrderDto> result, CheckoutBoletoRequest request,CustomerDto userDto)
        {
            var shipment = await _shippingService.PrepareShipment(new PrepareShipmentRequest(result.Value, request.PostalCode,request.ShippingMethod));
            shipment.DestinationAddressId = userDto.Addresses.FirstOrDefault(u => u.IsDefault && u.Type == AddressType.Shipping).Id;
            var shipmentResult = await _shippingService.CreateShipmentAsync(shipment);
            return shipmentResult;
        }
        private async Task<Result> CheckIfItemIsOnStock(CheckoutBoletoRequest request)
        {
            if (!(request.Items.Count > 0 && request.Items.All(i => i.Quantity > 0)))
            {
                return Result.Fail("You can't order a item with 0 products or create a order with 0 items", request);                
            }
            var products = await _productService.GetProductsByIdsAsync(request.Items.Select(i => i.ProductId).ToArray());
            //if (!(request.Items.HasStockForOrderItems(products)))
            if(request.Items.Any(i => products.Any(p => p.Id == i.Product.Id && i.Quantity <= p.UnitsInStock)))
            {
                return Result.Fail("looks like you have items on your order that ask for quantity that the store don't have on stock now", new { request, products });
            }
            return Result.Ok("request ask for enough item on stock");
        }
                              
    }        
}
