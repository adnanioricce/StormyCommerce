using System;

namespace StormyCommerce.Module.PagarMe.Services
{
    public class PagarMeService : IPaymentService
    {
        private readonly HttpClient _client;
        private readonly IStormyRepository<Payment> _paymentRepository;
        // private readonly PagarMeService
        public PagarMeService(HttpClient client,
        IStormyRepository<Payment> paymentRepository)
        {
            _client = client;
            _client.BaseAddress = "https://api.pagar.me/1/";
            _paymentRepository = paymentRepository;
        }
        public async Task<Result> Charge(PaymentDto payment)
        {
            throw new NotImplementedException();
        }
        public async Task<Result> Refund(PaymentDto payment)
        {
            throw new NotImplementedException();
        }
        public async Task<Result> Cancel(PaymentDto payment)
        {
            throw new NotImplementedException();
        }
    }
}
