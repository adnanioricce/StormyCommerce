using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PagarMe;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Payments;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Order.Request;
using StormyCommerce.Core.Models.Payment.Request;
using StormyCommerce.Core.Models.Payment.Response;

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
            var products = await _productService.GetProductsByIdsAsync(items.Select(i => i.StormyProductId).ToArray());
            var orderItems = products
                .Select(p =>
                new OrderItemDto(
                    p.UnitPrice,
                    items.FirstOrDefault(i => i.StormyProductId == p.Id).Quantity,
                    _mapper.Map<StormyProduct, ProductDto>(p))
                ).ToList();
            return orderItems;
        }
        private StormyOrder MapCreditCardTransactionToOrder(Transaction transaction,ProcessPaymentRequest request)
        {
            var order = new StormyOrder
            {
                OrderDate = DateTime.UtcNow,
                Status = OrderStatus.PaymentReceived,
                RequiredDate = DateTime.UtcNow,
                OrderUniqueKey = Guid.NewGuid(),
                TotalPrice = ((decimal)(transaction.Amount + transaction.Cost) / 100),
                PaymentDate = transaction.DateCreated,
                PickUpInStore = request.PickUpOnStore,
            };
            order.Payment = new StormyPayment
            {
                Amount = (decimal)(request.Amount) / 100,
                CreatedOn = DateTimeOffset.UtcNow,
                GatewayTransactionId = transaction.Id,
                PaymentMethod = Core.Entities.Payments.PaymentMethod.CreditCard,
                PaymentStatus = PaymentStatus.Successful,
                PaidOutAt = transaction.DateCreated,
                PaymentFee = transaction.Cost                
            };
            order.Items = request.Items.Select(i => new OrderItem
            {
                StormyProductId = i.Product.Id,
                Quantity = i.Quantity,
                Price = i.Price
            }).ToList();
            return order;
        }
        private StormyOrder MapBoletoTransactionToOrder(Transaction transaction,ProcessPaymentRequest request)
        {
            var order = new StormyOrder
            {
                OrderDate = DateTime.UtcNow,
                Status = OrderStatus.PendingPayment,
                RequiredDate = !(transaction.BoletoExpirationDate == null) ? transaction.BoletoExpirationDate.Value : DateTime.UtcNow,
                OrderUniqueKey = Guid.NewGuid(),
                TotalPrice = transaction.Amount,
                PaymentDate = transaction.DateCreated,
                PickUpInStore = request.PickUpOnStore,
            };
            order.Payment = new StormyPayment
            {
                Amount = (decimal)(request.Amount) / 100,
                CreatedOn = DateTimeOffset.UtcNow,
                GatewayTransactionId = transaction.Id,
                PaymentMethod = Core.Entities.Payments.PaymentMethod.Boleto,
                PaymentStatus = PaymentStatus.Pending,
                BoletoUrl = transaction.BoletoUrl,
                BoletoBarcode = transaction.BoletoBarcode,                
            };
            order.Items = request.Items.Select(i => new OrderItem
            {
                StormyProductId = i.Product.Id,
                Quantity = i.Quantity,
                Price = i.Price
            }).ToList();                      
            return order;
        }

        
    }

}
