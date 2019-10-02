using AutoMapper;
using PagarMe;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using System;
using System.Threading.Tasks;

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
        public async Task<Result> Charge(TransactionVm transactionVm)
        {      
            var transaction = _mapper.Map<Transaction>(transactionVm);
            transaction.PaymentMethod = (PaymentMethod)transactionVm.PaymentMethod;
            await transaction.SaveAsync();                                          
            return Result.Ok();
        }
        public Transaction GetTransactionById(string id)
        {
            return _pagarMeService.Transactions.Find(id,true);
        }                
    }
}
