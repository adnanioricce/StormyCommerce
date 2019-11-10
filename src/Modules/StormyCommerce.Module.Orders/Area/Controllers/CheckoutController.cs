using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PagarMe;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using System;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using StormyCommerce.Module.Orders.Services;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using System.Collections.Generic;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Customer;
using PagarMe.Model;
using StormyCommerce.Infraestructure.Interfaces;
using System.Net.Http;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IShippingService _shippingService;
        private readonly CorreiosService _correiosService;
        private readonly IUserIdentityService _identityService;
        private readonly IStormyRepository<CustomerAddress> _addressRepository;
        private readonly PagarMeService _pagarMeService;
        //private readonly PagarMeWrapper _pagarmeService;        
        private readonly IMapper _mapper;
        public CheckoutController(IOrderService orderService,
        IProductService productService,
        IShippingService shippingService,
        CorreiosService correiosService,
        //PagarMeWrapper pagarMeService,
        IUserIdentityService userIdentityService,
        IStormyRepository<CustomerAddress> addressRepository,
        PagarMeService pagarMeService,
        IMapper mapper)
        {
            _orderService = orderService;
            _productService = productService;
            _shippingService = shippingService;                        
            _identityService = userIdentityService;
            _addressRepository = addressRepository;
            _correiosService = correiosService;
            _pagarMeService = pagarMeService;
            _mapper = mapper;
        }
        //[HttpPost("boleto")]
        //[ValidateModel]                
        //public async Task<IActionResult> CheckoutBoleto([FromBody]BoletoCheckoutRequest requestModel)
        //{
        //    Dictionary<long, StormyProduct> products = (await _productService.GetProductsByIdsAsync(requestModel.Items.Select(it => it.ProductId).ToArray())).ToDictionary(p => p.Id);
        //    decimal amountToPay = requestModel.Items.Sum(it => products.GetValueOrDefault(it.ProductId).UnitPrice * it.Quantity);
        //    var customer = _identityService.GetUserByEmail(HttpContext.User.Claims.FirstOrDefault(c => c.Type.Contains("email")).Value);
        //    var shipment = await CreateShipment(products,requestModel);
        //    shipment.SafeAmount = amountToPay / 100;
        //    var shipcalcRequest = new DeliveryCalculationRequest
        //    {
        //        Height = (decimal)shipment.TotalHeight,
        //        Width = (decimal)shipment.TotalWidth,
        //        Length = (decimal)shipment.TotalLength,
        //        Weight = (decimal)shipment.TotalWeight,
        //        ValorDeclarado = shipment.SafeAmount,
        //        DestinationPostalCode = requestModel.DestinationPostalCode,
        //        WarningOfReceiving = "N",
        //        ServiceCode = requestModel.ShippingMethod,
        //        FormatCode = FormatCode.CaixaOuPacote,
        //        Diameter = 0,
        //        MaoPropria = "N",
        //        OriginPostalCode = requestModel.DestinationPostalCode
        //    };                                     
        //    var shippingPrice = (await _correiosService.CalculateDeliveryPriceAndTime(shipcalcRequest)).Options.Min(p => p.Price).Replace("R$","").Replace(",",".");
        //    var transaction = _mapper.Map<BoletoCheckoutRequest,TransactionVm>(requestModel);
        //    //The pagarme service represent the value in cents,so 1000 is actually R$10            
        //    transaction.PostbackUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/api/Checkout/postback";
        //    transaction.Async = true;
        //    transaction.Items.AddRange(_mapper.Map<List<PagarMeItem>>(products));
        //    transaction.Customer = _mapper.Map<PagarMeCustomerVm>(customer);            
        //    transaction.Amount = Convert.ToInt32((amountToPay + Convert.ToDecimal(shippingPrice)) * 100);            
        //    Result<OrderDto> order = await _orderService.CreateOrderAsync(_mapper.Map<StormyOrder>(transaction));    

        //    var result = await _pagarmeService.ChargeAsync(transaction);
        //    if (!result.Success)
        //    {
        //        return BadRequest(Result.Fail("Don't was possible to charge the order, check the credentials and try again"));
        //    }
        //    order.Value.Payment.PaymentStatus = result.Success ? PaymentStatus.Pending : PaymentStatus.Failed;            
        //    Result editResult = await _orderService.EditOrderAsync(order.Value.OrderUniqueKey,_mapper.Map<OrderDto,StormyOrder>(order.Value));             
        //    if(!editResult.Success)
        //    {
        //        return BadRequest(Result.Fail("We can't validate the order,check the credentials and try again"));
        //    }            
        //    return Ok(new BoletoCheckoutResponse{
        //        Result = order,
        //        BoletoUrl = transaction.BoletoUrl,
        //        BoletoBarcode = transaction.BoletoBarcode
        //    });                        
        //}
        [HttpPost("boleto")]
        [ValidateModel]    
        public async Task<ActionResult<BoletoCheckoutResponse>> SimpleCheckoutBoleto([FromBody]SimpleBoletoCheckoutRequest request)
        {
            var user = await _identityService.GetUserByClaimPrincipal(User);
            //var pagCustomer = _pagarMeService.Customers.Find(_mapper.Map<StormyCustomer, Customer>(user));            
            //if(pagCustomer == null)
            //{
                var pagCustomer = _mapper.Map<StormyCustomer, Customer>(user);                
            //}
            var transaction = new Transaction();
            transaction.Customer = pagCustomer;
            transaction.Amount = (int)(request.Amount * 100);
            transaction.Billing = _mapper.Map<StormyCustomer, Billing>(user);
            transaction.Async = true;
            transaction.PostbackUrl = $"{this.HttpContext.Request.Scheme}://{this.Request.Host}/api/Checkout/postback";
            await transaction.SaveAsync();
            //var order = _orderService.CreateOrderAsync(_mapper.Map<Transaction, StormyOrder>(transaction));
            return Ok(Result.Ok("transaction performed with success"));
        }
        [HttpPost("postback")]
        [ValidateModel]
        public async Task<IActionResult> CheckoutPostback(Postback postback)
        {
            return NoContent();
        }        

        private async Task<Shipment> CreateShipment(Dictionary<long,StormyProduct> products,BoletoCheckoutRequest requestModel)
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
