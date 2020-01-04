using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Module.ShoppingCart.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Payments.Interfaces;
using StormyCommerce.Module.Payments.Models.Requests;
using Payment = SimplCommerce.Module.Payments.Models.Payment;
namespace StormyCommerce.Module.PaymentsPagarMe.Services
{
    public class PaymentProcessor : IPaymentProcessor
    {        
        private readonly PagarMeWrapper _pagarMeWrapper;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public PaymentProcessor(PagarMeWrapper pagarMeWrapper,
            IProductService productService,
            IMapper mapper)
        {
            _pagarMeWrapper = pagarMeWrapper;
            _productService = productService;
            _mapper = mapper;
        }
        
        public async Task<ProcessPaymentResponse> ProcessBoletoPaymentRequestAsync(CheckoutBoletoRequest request, CustomerDto customerDto)
        {
            var items = await GetOrderItemsAsync(request.Items);
            var processRequest = new ProcessPaymentRequest(request, items, customerDto);            
            var transaction = _pagarMeWrapper.CreateSimpleTransaction(processRequest);
            var result = _pagarMeWrapper.Charge(transaction);
            var order = MapBoletoTransactionToOrder(processRequest);
            return new ProcessPaymentResponse(order,result);
        }
        public async Task<ProcessPaymentResponse> ProcessCreditCardPaymentAsync(CheckoutCreditCardRequest request,CustomerDto customerDto)
        {
            var items = await GetOrderItemsAsync(request.Items);
            var processRequest = new ProcessPaymentRequest(request,items, customerDto);
            var transaction = _pagarMeWrapper.CreateSimpleTransaction(processRequest);
            var result = _pagarMeWrapper.Charge(transaction);
            processRequest.Amount = transaction.Amount;
            processRequest.Cost = transaction.Cost;
            processRequest.DateCreated = transaction.DateCreated.Value;
            var order = MapCreditCardTransactionToOrder(processRequest);
            return new ProcessPaymentResponse(order, result);
        }
        private async Task<List<CartItem>> GetOrderItemsAsync(List<CartItem> items)
        {
            var products = await _productService.GetProductsByIdsAsync(items.Select(i => i.ProductId).ToArray());
            var orderItems = products
                .Select(p =>
                new CartItem {
                    Product = p,
                    Quantity = items.FirstOrDefault(i => i.ProductId == p.Id).Quantity                    
                }
                ).ToList();
            return orderItems;
        }
        private Order MapCreditCardTransactionToOrder(ProcessPaymentRequest request)
        {
            var order = new Order
            {
                CreatedOn = DateTime.UtcNow,
                OrderStatus = OrderStatus.PaymentReceived,
                RequiredDate = DateTime.UtcNow,
                OrderUniqueKey = Guid.NewGuid(),
                OrderTotal = ((decimal)(request.Amount + request.Cost) / 100),
                PaymentDate = request.DateCreated,
                PickUpInStore = request.PickUpOnStore,
            };
            var Payment = new Payment
            {
                Amount = (decimal)(request.Amount) / 100,
                CreatedOn = DateTimeOffset.UtcNow,
                GatewayTransactionId = request.GatewayTransactionId,
                Method = SimplCommerce.Module.Payments.Models.PaymentMethod.CreditCard,
                Status = PaymentStatus.Successful,
                PaidOutAt = request.DateCreated,
                PaymentFee = request.Cost
            };
            order.OrderItems = request.Items.Select(i => new OrderItem
            {
                ProductId = i.Product.Id,
                Quantity = i.Quantity,
                ProductPrice = i.Product.Price
            }).ToList();
            return order;
        }
        private Order MapBoletoTransactionToOrder(ProcessPaymentRequest request)
        {
            var order = new Order
            {
                CreatedOn = DateTime.UtcNow,
                OrderStatus = OrderStatus.PendingPayment,
                RequiredDate = (request.ExpirationDate.HasValue) ? request.ExpirationDate.Value : DateTime.UtcNow,
                OrderUniqueKey = Guid.NewGuid(),
                OrderTotal = request.Amount,
                PaymentDate = request.DateCreated,
                PickUpInStore = request.PickUpOnStore,
            };
            var Payment = new Payment
            {
                Amount = (decimal)(request.Amount) / 100,
                CreatedOn = DateTimeOffset.UtcNow,
                GatewayTransactionId = request.GatewayTransactionId,
                Method = PaymentMethod.Boleto,
                Status = PaymentStatus.Pending,
                BoletoUrl = request.BoletoUrl,
                BoletoBarcode = request.BoletoBarcode,
            };
            order.OrderItems = request.Items.Select(i => new OrderItem
            {
                ProductId = i.Product.Id,
                Quantity = i.Quantity,
                ProductPrice = i.Product.Price
            }).ToList();                      
            return order;
        }        
    }

}
