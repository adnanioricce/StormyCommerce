using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.ShoppingCart.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Payments.Interfaces;
using StormyCommerce.Module.Payments.Models.Requests;

namespace StormyCommerce.Module.Orders.Services
{
    public class PaymentProcessor : IPaymentProcessor
    {
        private readonly PagarMeWrapper _pagarMeWrapper;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public PaymentProcessor(PagarMeWrapper pagarMeWrapper,IProductService productService,IMapper mapper)
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
            var order = MapBoletoTransactionToOrder(transaction, processRequest);
            return new ProcessPaymentResponse(order,result);
        }
        public async Task<ProcessPaymentResponse> ProcessCreditCardPaymentAsync(CheckoutCreditCardRequest request,CustomerDto customerDto)
        {
            var items = await GetOrderItemsAsync(request.Items);
            var processRequest = new ProcessPaymentRequest(request,items, customerDto);
            var transaction = _pagarMeWrapper.CreateSimpleTransaction(processRequest);
            var result = _pagarMeWrapper.Charge(transaction);
            var order = MapCreditCardTransactionToOrder(transaction, processRequest);
            return new ProcessPaymentResponse(order, result);
        }               
        private async Task<List<OrderItemDto>> GetOrderItemsAsync(List<CartItem> items)
        {
            var products = await _productService.GetProductsByIdsAsync(items.Select(i => i.ProductId).ToArray());
            var orderItems = products
                .Select(p =>
                new OrderItemDto(
                    p.Price,
                    items.FirstOrDefault(i => i.ProductId == p.Id).Quantity,
                    _mapper.Map<Product, ProductDto>(p))
                ).ToList();
            return orderItems;
        }
        private Order MapCreditCardTransactionToOrder(Transaction transaction,ProcessPaymentRequest request)
        {
            var order = new Order
            {
                CreatedOn = DateTime.UtcNow,
                OrderStatus = OrderStatus.PaymentReceived,
                RequiredDate = DateTime.UtcNow,
                OrderUniqueKey = Guid.NewGuid(),
                OrderTotal = ((decimal)(transaction.Amount + transaction.Cost) / 100),
                PaymentDate = transaction.DateCreated.Value,
                PickUpInStore = request.PickUpOnStore,
            };
            //order.Payment = new Payment
            //{
            //    Amount = (decimal)(request.Amount) / 100,
            //    CreatedOn = DateTimeOffset.UtcNow,
            //    GatewayTransactionId = transaction.Id,
            //    PaymentMethod = SimplCommerce.Module.Payments.Models.PaymentMethod.CreditCard,
            //    Status = PaymentStatus.Successful,
            //    PaidOutAt = transaction.DateCreated,
            //    PaymentFee = transaction.Cost                
            //};
            order.OrderItems = request.Items.Select(i => new OrderItem
            {
                ProductId = i.Product.Id,
                Quantity = i.Quantity,
                ProductPrice = i.Price
            }).ToList();
            return order;
        }
        private Order MapBoletoTransactionToOrder(Transaction transaction,ProcessPaymentRequest request)
        {
            var order = new Order
            {
                CreatedOn = DateTime.UtcNow,
                OrderStatus = OrderStatus.PendingPayment,
                RequiredDate = !(transaction.BoletoExpirationDate == null) ? transaction.BoletoExpirationDate.Value : DateTime.UtcNow,
                OrderUniqueKey = Guid.NewGuid(),
                OrderTotal = transaction.Amount,
                PaymentDate = transaction.DateCreated.Value,
                PickUpInStore = request.PickUpOnStore,
            };
            //order.Payment = new StormyPayment
            //{
            //    Amount = (decimal)(request.Amount) / 100,
            //    CreatedOn = DateTimeOffset.UtcNow,
            //    GatewayTransactionId = transaction.Id,
            //    PaymentMethod = Core.Entities.Payments.PaymentMethod.Boleto,
            //    PaymentStatus = PaymentStatus.Pending,
            //    BoletoUrl = transaction.BoletoUrl,
            //    BoletoBarcode = transaction.BoletoBarcode,                
            //};
            order.OrderItems = request.Items.Select(i => new OrderItem
            {
                ProductId = i.Product.Id,
                Quantity = i.Quantity,
                ProductPrice = i.Price
            }).ToList();                      
            return order;
        }

        
    }

}
