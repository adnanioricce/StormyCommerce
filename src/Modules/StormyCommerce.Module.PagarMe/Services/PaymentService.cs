using System;
using System.Threading.Tasks;
using AutoMapper;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Payment.Request;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;

namespace StormyCommerce.Module.PagarMe.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IStormyRepository<Payment> _paymentRepository;
        private readonly PagarMeWrapper _pagarmeWrapper;
        private readonly IMapper _mapper;
        public PaymentService(IStormyRepository<Payment> paymentRepository,PagarMeWrapper pagarMeWrapper,IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _pagarmeWrapper = pagarMeWrapper;
            _mapper = mapper;
        }
        public Task AddPaymentAsync(Payment payment)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Cancel(PaymentDto payment)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result> Charge(BoletoPaymentRequest payment)
        {
            //var result = await _pagarmeWrapper.ChargeAsync(new Area.PagarMe.ViewModels.TransactionVm
            //{
            //    Amount = Convert.ToInt32(payment.Amount * 100),
            //    Customer = _mapper.Map<CustomerDto, PagarMeCustomerVm>(payment.Customer),

            //});
            throw new NotImplementedException();
        }

        public Task<PaymentDto> GetPaymentById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Refund(PaymentDto payment)
        {
            throw new System.NotImplementedException();
        }
    }
}
