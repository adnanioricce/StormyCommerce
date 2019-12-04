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
using StormyCommerce.Core.Models.Order.Request;

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
        public async Task<ActionResult<CheckoutResponse>> BoletoCheckout([FromBody] CheckoutBoletoRequest request)
        {            
            var checkResult = await CheckIfItemIsOnStock(request);
            if (!checkResult.Success) return BadRequest(checkResult);                                 
            var user = await _identityService.GetUserByClaimPrincipal(User);
            var userDto = _mapper.Map<StormyCustomer, CustomerDto>(user);            
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
            var userDto = _mapper.Map<StormyCustomer, CustomerDto>(user);            
            var order = BuildOrderForCreditCardCheckout(request);
            var createOrderResult = await _orderService.CreateOrderAsync(order);
            var shipment = await _shippingService.PrepareShipment(new PrepareShipmentRequest(createOrderResult.Value, request.PostalCode, request.ShippingMethod));
            shipment.DestinationAddressId = userDto.Addresses.FirstOrDefault(u => u.IsDefault && u.Type == AddressType.Shipping).Id;
            var shipmentResult = await _shippingService.CreateShipmentAsync(shipment);            
            var orderDto = await _orderService.GetOrderByIdAsync(createOrderResult.Value.Id);
            var response = await _paymentProcessor.ProcessCreditCardPaymentAsync(request,userDto);
            if (!response.Result.Success) return BadRequest(response.Result);            
            return Ok(new CreditCardCheckoutResponse { 
                Payment = orderDto.Value.Payment,
                Order = orderDto.Value,
                Shipment = orderDto.Value.Shipment
            });
        }
        [HttpPost("postback")]
        [ValidateModel]
        public async Task<IActionResult> CheckoutPostback(Postback postback)
        {
            return NoContent();
        }   
        private StormyOrder BuildOrderForCreditCardCheckout(CheckoutCreditCardRequest request)
        {            
            return new StormyOrder
            {
                Payment = new Core.Entities.Payments.StormyPayment
                {
                    Amount = request.Amount,
                    PaymentMethod = Core.Entities.Payments.PaymentMethod.CreditCard,
                    CreatedOn = DateTimeOffset.UtcNow,
                    PaymentStatus = Core.Entities.Payments.PaymentStatus.Processing,                    
                }
            };
        }
        private async Task<Result<OrderDto>> CreateOrderForCheckout(CheckoutBoletoRequest request,CustomerDto userDto,string userId)
        {
            var response = await _paymentProcessor.ProcessBoletoPaymentRequestAsync(request, userDto);
            response.Order.StormyCustomerId = userId;
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
            var products = await _productService.GetProductsByIdsAsync(request.Items.Select(i => i.StormyProductId).ToArray());
            if (!(request.Items.HasStockForOrderItems(products)))
            {
                return Result.Fail("looks like you have items on your order that ask for quantity that the store don't have on stock now", new { request, products });
            }
            return Result.Ok("request ask for enough item on stock");
        }
                              
    }        
}
