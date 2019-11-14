//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using AutoMapper;
//using PagarMe;
//using PagarMe.Model;
//using StormyCommerce.Core.Models;

//namespace StormyCommerce.Module.Orders.Services
//{
//    public class PagarMeWrapper
//    {
//        private readonly PagarMeService _pagarMeService;
//        private readonly IMapper _mapper;
//        public PagarMeWrapper(IMapper mapper)
//        {
//            _pagarMeService = PagarMeService.GetDefaultService();
//            _mapper = mapper;
//        }
//        public async Task<List<Transaction>> GetAllTransactionAsync()
//        {
//            return (List<Transaction>)(await _pagarMeService.Transactions.FindAllAsync(new Transaction()));
//        }
//        public async Task<Result> ChargeAsync(StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels.TransactionVm transactionVm)
//        {
//            //var transaction = _mapper.Map<Transaction>(transactionVm);
            
//            return Result.Ok();
//        }
//        public Result CaptureTransaction(string idOrToken, int amount)
//        {
//            var transaction = _pagarMeService.Transactions.Find(idOrToken);
//            transaction.Capture(amount);
//            return Result.Ok("Operation captured with success");
//        }
//        public Transaction GetTransactionById(string id)
//        {
//            return _pagarMeService.Transactions.Find(id, true);
//        }
//        public void RefundTransaction(string transactionId)
//        {
//            var transaction = _pagarMeService.Transactions.Find(transactionId);
//            transaction.Refund();
//        }
//        public Task<Transaction> GetTransactionByIdAsync(string id)
//        {
//            return _pagarMeService.Transactions.FindAsync(id);
//        }
//    }
//}
