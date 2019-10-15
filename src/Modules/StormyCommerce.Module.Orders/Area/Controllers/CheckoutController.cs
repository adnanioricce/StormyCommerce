using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagarMe;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using StormyCommerce.Module.PagarMe.Services;
using System;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
namespace StormyCommerce.Module.Orders.Area.Controllers
{
    [Area("Orders")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;                
        private readonly ICustomerService _customerService;
        private readonly CorreiosService _correiosService;
        private readonly IShippingService _shippingService;
        private readonly PagarMeWrapper _pagarmeService;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public CheckoutController(IOrderService orderService, 
        IPaymentService paymentService,
        IShippingService shippingService, 
        ILogger logger,
        PagarMeWrapper pagarMeService,
        ICustomerService customerService,
        IMapper mapper)
        {
            _orderService = orderService;            
            _paymentService = paymentService;
            _shippingService = shippingService;
            _logger = logger;
            _pagarmeService = pagarMeService;
            _customerService = customerService;
            _mapper = mapper;
        }

        ///<summary>
        /// Nothing working yet
        ///</summary>
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Checkout([FromBody]CheckoutOrderVm checkoutVm)
        {                        
            throw new NotImplementedException();
        }
        [HttpPost("boleto")]
        [ValidateModel]        
        public async Task<IActionResult> CheckoutBoleto([FromBody]BoletoCheckoutViewModel boletoCheckoutViewModel)
        {                        
            //TODO:Get current customer instead
            
            var customer = await _customerService.GetCustomerByUserNameOrEmail("",boletoCheckoutViewModel.CustomerEmail);
            var transaction = boletoCheckoutViewModel.ToTransactionVm(customer);
            
            transaction.PostbackUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/api/Checkout/postback";
            transaction.Async = true;            
            
            var result = await _pagarmeService.ChargeAsync(transaction);            
            
            if(!result.Success) return BadRequest($"failed on the payment charge process, see the error code for more info\n {result.Error}");            
            
            var payment = _mapper.Map<PaymentDto>(transaction);            
            //TODO:define price type
            //the price has to be represented in cents
            var price = transaction.Amount / 100;            
            var order = BuildOrder(transaction,_mapper.Map<Payment>(payment),boletoCheckoutViewModel);
            transaction.Items.ForEach(item => 
            order.Items.Add(
                _mapper.Map<OrderItem>(item)
                ));                                 
            var shipment = _shippingService.BuildShipmentForOrder(order);            
            shipment.Order = order;             
            order.Shipment = shipment;
            if(shipment.DeliveryCost <= 0 && !order.PickUpInStore){
                var calcResult = await _correiosService.DefaultDeliveryCalculation(shipment);                
                shipment.DeliveryCost = decimal.Parse(calcResult.Servicos.FirstOrDefault().Valor
                .Replace("R$","")
                .Replace(",","."));
                order.Shipment = shipment;
            }                            
            await _orderService.CreateOrderAsync(order);
            return Ok();
            StormyOrder BuildOrder(TransactionVm _transactionVm,Payment _payment,BoletoCheckoutViewModel checkoutVm){
                return new StormyOrder{
                    Customer = customer,
                    DeliveryCost = _transactionVm.Shipping.Fee, 
                    DeliveryDate = Convert.ToDateTime(_transactionVm.Shipping.DeliveryDate),
                    PaymentMethod = "boleto",
                    Payment = _payment,
                    ShippingStatus = Core.Entities.Shipping.ShippingStatus.NotShippedYet,
                    Status = OrderStatus.New,   
                    ShippingMethod = checkoutVm.ShippingMethod,                             
                    //TODO:maybe a value object for the price operations? they don't seem like a value type for me
                    TotalPrice = price,
                    ShippingAddress = _transactionVm.Shipping.Address                                                
                };           
            }                                                    
        }
        
    }    
}
