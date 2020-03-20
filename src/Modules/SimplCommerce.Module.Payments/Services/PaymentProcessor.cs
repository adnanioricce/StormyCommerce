using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Module.ShoppingCart.Models;

namespace SimplCommerce.Module.Payments.Services
{
    public class PaymentProcessor : IPaymentProcessor
    {
        private readonly IRepository<Cart> _cartRepository;
        private readonly IRepository<Address> _addressRepository;
        private readonly IRepository<Payment> _paymentRepository;
        private readonly IPaymentProvider _paymentProvider;
        public ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
        {                        
            var response = _paymentProvider.ProcessTransaction(request);            
            return response;
        }
    }
}   