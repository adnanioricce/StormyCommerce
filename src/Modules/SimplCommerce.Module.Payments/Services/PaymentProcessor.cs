using System.Linq;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Module.ShoppingCart.Models;

namespace SimplCommerce.Module.Payments.Services
{
    public class PaymentProcessor : IPaymentProcessor
    {
        private readonly IRepository<Cart> _cartRepository;        
        private readonly IRepository<Payment> _paymentRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IPaymentProvider _paymentProvider;
        public PaymentProcessor(IPaymentProvider provider,IRepository<Payment> paymentRepository,IRepository<Cart> cartRepository)
        {
            _paymentProvider = provider;
            _paymentRepository = paymentRepository;
            _cartRepository = cartRepository;
        }
        public ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
        {
            var order = _orderRepository.Query().FirstOrDefault(o => o.Id == request.OrderId);                
            var response = _paymentProvider.ProcessTransaction(request);            
            return response;
        }
    }
}   
