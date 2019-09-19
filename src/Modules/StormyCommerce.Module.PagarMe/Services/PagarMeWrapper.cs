using AutoMapper;
using PagarMe;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using System;

namespace StormyCommerce.Module.PagarMe.Services
{
    //TODO:
    public class PagarMeWrapper
    {
        private readonly PagarMeService _pagarMeService;
        private readonly IStormyRepository<Payment> _paymentRepository;
        private readonly IMapper _mapper;
        public PagarMeWrapper(PagarMeService pagarMeService,IStormyRepository<Payment> paymentRepository,IMapper mapper)
        {            
            _pagarMeService = pagarMeService;            
            _paymentRepository = paymentRepository;
            _mapper = mapper;            
        }        
        public Result CreateBoletoTransaction(TransactionVm transaction)
        {
            if (transaction == null) return Result.Fail($"given transaction is null in {nameof(CreateBoletoTransaction)} at {DateTimeOffset.UtcNow}");
            if (transaction.Customer == null) return Result.Fail($"We can't perform a transaction without a customer {nameof(CreateBoletoTransaction)} at {DateTimeOffset.UtcNow}");
            if (transaction.Documents == null) return Result.Fail($"We need document in order to authenticate this operation. on {nameof(CreateBoletoTransaction)} at {DateTimeOffset.UtcNow}");
            var pagarmeTransaction = _mapper.Map<Transaction>(transaction);
            //pagarmeTransaction.


            return Result.Ok();
        }   
        //public Result CheckoutBoleto(Transaction transaction)
        //{
        //    var transaction = _mapper.Map<TransactionVm, Transaction>(transactionVm);
        //    var payment = _mapper.Map<Payment>(transaction);
        //    var shipping = _mapper.Map<Shipment>(transaction);

        //    payment.PaymentStatus = PaymentStatus.Pending;
        //    await _paymentRepository.AddAsync(payment);
        //    transaction.Save();
        //}
        
    }
}
