using System;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces.Domain.Payments;
using System.Threading.Tasks;
using StormyCommerce.Core.Models;
using System.Net.Http;
using StormyCommerce.Core.Interfaces;

namespace StormyCommerce.Module.Orders.Services
{
    public class PagarmeService : IPaymentService<Payment>
    {        
        private readonly IStormyRepository<Payment> _paymentRepository;        
        public PagarmeService(IStormyRepository<Payment> paymentRepository)
        {
            // _client = client;
            // _client.BaseAddress = new Uri("https://api.pagar.me/1");
            _paymentRepository = paymentRepository;
        }
        public Task<Result<Payment>> Charge(Payment payment)
        {
            // PagarMeService.DefaultApiKey = "ak_test_grXijQ4GicOa2BLGZrDRTR5qNQxJW0";

            // Transaction transaction = new Transaction();

            // transaction.Amount = 1000;
            // transaction.PaymentMethod = PaymentMethod.Boleto;

            // transaction.Save();
            throw new NotImplementedException();
        }

        public Task<Result<Payment>> Refund(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
