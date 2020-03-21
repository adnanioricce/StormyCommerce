using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Orders.Models;
using System.Linq;
using Microsoft.Extensions.Options;
using SimplCommerce.Module.PagarMe.Settings;

namespace SimplCommerce.Module.PagarMe.Services
{
    public class PagarMeProcessor : IPaymentProvider
    {        
        private readonly IRepository<Order> _orderRepository;
        private readonly IOptions<PagarMeAdditionalSettings> _paymentSettings;
        public PagarMeProcessor(IRepository<Order> orderRepository, IOptions<PagarMeAdditionalSettings> options)
        {
            _paymentSettings = options;
        }

        public void ConfigureProvider(PaymentProvider provider,PaymentProviderAdditionalSettings settings)
        {
            
        }

        public ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
        {
            //PaymentProcessor 
            var order = _orderRepository.Query().FirstOrDefault(o => o.Id == request.OrderId);
            return new ProcessTransactionResponse{
                Success = false
            };
        }
    }
}
