using PagarMe;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using System;
using System.Threading.Tasks;

namespace StormyCommerce.Module.PagarMe.Services
{
    public class StormyPagarmeService : IPaymentService
    {
        private readonly IStormyRepository<Payment> _paymentRepository;
        private readonly PagarMeWrapper _pagarmeWrapper;
        public StormyPagarmeService(IStormyRepository<Payment> paymentRepository,
            PagarMeWrapper pagarmeWrapper)
        {
            _paymentRepository = paymentRepository;            
        }

        public Task<Result> Charge(PaymentDto payment)
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
