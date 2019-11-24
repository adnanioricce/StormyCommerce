using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PagarMe;
using PagarMe.Model;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.Orders.Area.Models.Orders;

namespace StormyCommerce.Module.Orders.Services
{
    public class PagarMeWrapper
    {
        private readonly PagarMeService _pagarMeService;        
        public PagarMeWrapper()
        {
            _pagarMeService = PagarMeService.GetDefaultService();            
        }
        public async Task<List<Transaction>> GetAllTransactionAsync()
        {
            return (List<Transaction>)(await _pagarMeService.Transactions.FindAllAsync(new Transaction()));
        }
        public Transaction CreateSimpleBoletoTransaction(SimpleBoletoCheckoutRequest request,StormyCustomer user)
        {
            Transaction transaction = new Transaction();
            transaction.Amount = 1000;
            transaction.PaymentMethod = PaymentMethod.Boleto;
            MapCustomerToTransactionCustomer(transaction, user);
            return transaction;
        }
        public Result Charge(Transaction transaction)
        {
            try
            {
                transaction.Save();
                return Result.Ok("transaction performed with success");
            }
            catch (PagarMeException ex)
            {
                string exceptionStr = HandleErrorMessage(ex);                
                return Result.Fail("Charge operation failed", exceptionStr);
            }
        }
        public Result CaptureTransaction(string idOrToken, int amount)
        {
            try
            {
                var transaction = _pagarMeService.Transactions.Find(idOrToken);
                transaction.Capture(amount);
            }catch(PagarMeException ex)
            {
                string exceptionStr = HandleErrorMessage(ex);
                return Result.Fail("Capture operation failed", exceptionStr);
            }
            return Result.Ok("Operation captured with success");
        }
        public Transaction GetTransactionById(string id)
        {
            return _pagarMeService.Transactions.Find(id, true);
        }
        public void RefundTransaction(string transactionId)
        {
            var transaction = _pagarMeService.Transactions.Find(transactionId);
            transaction.Refund();
        }        
        private string HandleErrorMessage(PagarMeException ex)
        {            
            string exceptionStr = "";
            foreach (var error in ex.Error.Errors)
            {
                exceptionStr = $@"The PagarMe Service throwed the following:Type:{error.Type},
                    Parameter:{error.Parameter},
                    Message:{error.Message}";                
            }
            return exceptionStr;
        }
        private void MapCustomerToTransactionCustomer(Transaction transaction, StormyCustomer user)
        {
            transaction.Customer = new Customer()
            {
                Country = "br",
                Type = CustomerType.Individual,
                Name = user.FullName,
                Email = user.Email,
                Documents = new Document[]{
                    new Document{
                        Type = DocumentType.Cpf,
                        Number = user.CPF
                    }
                },
                PhoneNumbers = new string[]{
                    "+551123456789"
                }
            };
        }
    }
}
