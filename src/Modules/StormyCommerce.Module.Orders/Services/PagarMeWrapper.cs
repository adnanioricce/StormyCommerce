using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PagarMe;
using PagarMe.Model;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Payment.Request;
using StormyCommerce.Module.Orders.Area.Models.Orders;

namespace StormyCommerce.Module.Orders.Services
{
    public class PagarMeWrapper
    {
        private readonly PagarMeService _pagarMeService;
        private readonly IMapper _mapper;
        public PagarMeWrapper(IMapper mapper)
        {
            _pagarMeService = PagarMeService.GetDefaultService();
            _mapper = mapper;
        }
        public async Task<List<Transaction>> GetAllTransactionAsync()
        {
            return (List<Transaction>)(await _pagarMeService.Transactions.FindAllAsync(new Transaction()));
        }
        public Transaction CreateSimpleTransaction(ProcessPaymentRequest request)
        {
            Transaction transaction = new Transaction();
            transaction.Amount = request.Amount;
            transaction.PaymentMethod = (PaymentMethod)request.PaymentMethod;
            MapCustomerToTransactionCustomer(transaction, request.Customer);
            MapItemsToTransactionItems(transaction, request.Items);
            return transaction;
        }

        private void MapItemsToTransactionItems(Transaction transaction, List<OrderItemDto> items)
        {            
            transaction.Item = items.Select(i => new Item
            {
                Id = i.Id.ToString(),
                Quantity = i.Quantity,
                Title = i.Product.ProductName,
                UnitPrice = (int)(i.Product.UnitPrice * 100),                
                Tangible = true
            }).ToArray();
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
        private void MapCustomerToTransactionCustomer(Transaction transaction, CustomerDto user)
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
