using AutoMapper;
using PagarMe;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;

namespace StormyCommerce.Module.PagarMe.Services
{
    //TODO:
    public class PagarMeWrapper
    {
        private readonly PagarMeService _pagarMeService;
        private readonly IStormyRepository<Payment> _paymentRepository;
        private readonly IMapper _mapper;
        public PagarMeWrapper(PagarMeService pagarMeService,
        IStormyRepository<Payment> paymentRepository,
        IMapper mapper)
        {            
            _pagarMeService = pagarMeService;            
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }        
        public Result SaveTransaction(Transaction transaction)
        {   
            transaction.Save();
            return Result.Ok();            
        }           
        public Result<string> CreateBoleto(Transaction transaction)
        {      
            var transactionResult = SaveTransaction(transaction);      
            if(!transactionResult.Success){
                return Result.Fail<string>(transactionResult.Error);   
            }            
            var entryTransaction = _pagarMeService.Transactions.Find(transaction.Id,true);
            return Result.Ok<string>(entryTransaction.BoletoUrl);
        }
        // public 
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
