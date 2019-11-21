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
using StormyCommerce.Core.Entities.Payments;

namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserIdentityService _identityService;                      
        private readonly IMapper _mapper;
        public CheckoutController(
        IUserIdentityService userIdentityService,
        IOrderService orderService,        
        IMapper mapper)
        {                                
            _identityService = userIdentityService;            
            _orderService = orderService;
            _mapper = mapper;
        }        
        [HttpPost("boleto")]
        [ValidateModel]    
        public async Task<ActionResult<BoletoCheckoutResponse>> SimpleCheckoutBoleto([FromBody]SimpleBoletoCheckoutRequest request)
        {
            var user = await _identityService.GetUserByClaimPrincipal(User);            
            var pagCustomer = _mapper.Map<StormyCustomer, Customer>(user);
                        
            Transaction transaction = new Transaction{
                Amount = 1000,
                PaymentMethod = PaymentMethod.Boleto,

                Customer = new Customer () {
                    Country = "br",
                    Type = CustomerType.Individual,
                    Name = user.FullName,
                    Email = user.Email,                
                    Documents = new Document[]{
                        new Document{
                            Type = DocumentType.Cpf,
                            Number = user.CPF
                        }
                    },                
                    PhoneNumbers = new string[]{
                        "+551123456789"
                    }                
                }
            };
                         
            try{    
                transaction.Save();           
            }catch(PagarMeException ex){                                
                Console.WriteLine($"HttpStatusCode from the PagarMeException:${ex.Error.HttpStatus}");
                string exceptionStr = "";
                foreach(var error in ex.Error.Errors){
                    exceptionStr = $@"The PagarMe Service throwed the following:Type:{error.Type},
                    Parameter:{error.Parameter},
                    Message:{error.Message}";
                    Console.WriteLine(exceptionStr);                    
                }                          
                return BadRequest(Result.Fail("transaction failed",exceptionStr));
            }
            string boletoUrl = transaction.BoletoUrl;
            string boletoBarcode = transaction.BoletoBarcode;
            var payment = new Payment{
                GatewayTransactionId = transaction.Id,
                Amount = request.Amount,
                PaymentMethod = request.PaymentMethod,
                PaymentFee = transaction.Cost,
                PaymentStatus = transaction.Status == TransactionStatus.WaitingPayment || transaction.Status == TransactionStatus.Authorized ? PaymentStatus.Pending : PaymentStatus.Failed,
                              
            };
            
            return Ok(Result.Ok("transaction performed with success"));
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
