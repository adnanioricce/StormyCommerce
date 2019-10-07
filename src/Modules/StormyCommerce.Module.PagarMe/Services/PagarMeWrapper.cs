using AutoMapper;
using PagarMe;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Module.PagarMe.Services
{    
    public class PagarMeWrapper
    {
        private readonly PagarMeService _pagarMeService;
        private readonly IStormyRepository<Payment> _paymentRepository;
        private readonly IMapper _mapper;
        public PagarMeWrapper(PagarMeService pagarMeService,
        IStormyRepository<Payment> paymentRepository,
        IMapper mapper)
        {            
            //if this doesn't work, try PagarMeService.GetDefaultService()
            _pagarMeService = pagarMeService;            
            _paymentRepository = paymentRepository;
            _mapper = mapper;            
        }        
        public async Task<List<Transaction>> GetAllTransactionAsync()
        {
            return (List<Transaction>)(await _pagarMeService.Transactions.FindAllAsync(new Transaction()));
        }
        public async Task<Result> Charge(TransactionVm transactionVm)
        {      
            var transaction = _mapper.Map<Transaction>(transactionVm);
            transaction.Async = true;
            transaction.PaymentMethod = (PaymentMethod)transactionVm.PaymentMethod;
            await transaction.SaveAsync();                                          
            return Result.Ok();
        }
        public Result CaptureTransaction(string idOrToken,int amount)
        {
            var transaction = _pagarMeService.Transactions.Find(idOrToken);
            transaction.Capture(amount);
            return Result.Ok("Operation captured with success");
        }
        public Transaction GetTransactionById(string id)
        {
            return _pagarMeService.Transactions.Find(id,true);
        }                
        public void RefundTransaction(string transactionId)
        {
            var transaction = _pagarMeService.Transactions.Find(transactionId);
            transaction.Refund();
        }
        public Task<Transaction> GetTransactionByIdAsync(string id)
        {
            return _pagarMeService.Transactions.FindAsync(id);
        }
    }
}
