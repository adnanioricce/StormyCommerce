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
        
        private readonly IUserIdentityService _identityService;                      
        private readonly IMapper _mapper;
        public CheckoutController(
        IUserIdentityService userIdentityService,        
        IMapper mapper)
        {                                
            _identityService = userIdentityService;            
            _mapper = mapper;
        }        
        [HttpPost("boleto")]
        [ValidateModel]    
        public async Task<ActionResult<BoletoCheckoutResponse>> SimpleCheckoutBoleto([FromBody]SimpleBoletoCheckoutRequest request)
        {
            var user = await _identityService.GetUserByClaimPrincipal(User);            
            var pagCustomer = _mapper.Map<StormyCustomer, Customer>(user);

            var transaction = new Transaction
            {
                Customer = pagCustomer,
                Amount = (int)(request.Amount * 100),
                Billing = _mapper.Map<StormyCustomer, Billing>(user),
                Address = _mapper.Map<CustomerAddress,Address>(user.DefaultBillingAddress),
                Shipping = _mapper.Map<CustomerAddress,Shipping>(user.DefaultShippingAddress),
                Async = true,
                PostbackUrl = $"{this.HttpContext.Request.Scheme}://{this.Request.Host}/api/Checkout/postback"
            };
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
