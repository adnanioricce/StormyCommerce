using System;
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
        public async Task<ProcessBoletoPaymentResponse> ProcessBoletoPayment(SimpleBoletoCheckoutRequest request,CustomerDto customerDto)
        {
            var processRequest = await MapToProcessRequest(request,customerDto);
            var transaction = _pagarMeWrapper.CreateSimpleBoletoTransaction(processRequest);
            var result = _pagarMeWrapper.Charge(transaction);            
            var order = MapToOrder(transaction, processRequest);
            return new ProcessBoletoPaymentResponse { 
                Order = order,
                Result = result
            };
        }
        private async Task<ProcessBoletoPaymentRequest> MapToProcessRequest(SimpleBoletoCheckoutRequest request,CustomerDto customerDto)
        {
            var products = await _productService.GetProductsByIdsAsync(request.Items.Select(i => i.StormyProductId).ToArray());
            var items = products
                .Select(p =>
                new OrderItemDto(
                    p.UnitPrice,
                    request.Items.FirstOrDefault(i => i.StormyProductId == p.Id).Quantity,
                    _mapper.Map<StormyProduct, ProductDto>(p))
                )
                .ToList();            
            return new ProcessBoletoPaymentRequest {
                Amount = (int)(request.Amount / 100),
                Items = items,
                Customer = customerDto,
                PaymentMethod = request.PaymentMethod,
                PickUpOnStore = request.PickUpOnStore
            } ;
        }
        private StormyOrder MapToOrder(Transaction transaction,ProcessBoletoPaymentRequest request)
        {
            var order = new StormyOrder
            {
                OrderDate = DateTime.UtcNow,
                Status = Core.Entities.Order.OrderStatus.PendingPayment,
                RequiredDate = transaction.BoletoExpirationDate.Value,
                OrderUniqueKey = Guid.NewGuid(),
                TotalPrice = transaction.Amount,
                PaymentDate = transaction.DateCreated.Value,
                PickUpInStore = request.PickUpOnStore,
            };
            order.Payment = new Payment
            {
                Amount = request.Amount,
                CreatedOn = DateTimeOffset.UtcNow,
                GatewayTransactionId = transaction.Id,
                PaymentMethod = "boleto",
                PaymentStatus = PaymentStatus.Pending,
                BoletoUrl = transaction.BoletoUrl,
                BoletoBarcode = transaction.BoletoBarcode,
                Order = order
            };
            order.Items = request.Items.Select(i => new OrderItem
            {
                StormyProductId = i.Product.Id,
                Quantity = i.Quantity,
                Price = i.Price
            }).ToList();
            //order.Shipment = new Shipment()            
            return order;
        }
    }

}
