using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagarMe;
using SimplCommerce.Module.ShoppingCart.Models;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.Payments.Models.Requests;

namespace StormyCommerce.Module.Orders.Services
{
    public class PagarMeWrapper
    {
        private readonly PagarMeService _pagarMeService;        
        public PagarMeWrapper(PagarMeService pagarMeService)
        {
            _pagarMeService = pagarMeService;            
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
            if (transaction.PaymentMethod == PaymentMethod.CreditCard)
            {
                var card = CreateCard();
                transaction.Card = card.Value;
            }
            MapCustomerToTransactionCustomer(transaction, request.Customer);
            MapItemsToTransactionItems(transaction, request.Items);
            return transaction;
        }

        private void MapItemsToTransactionItems(Transaction transaction, List<CartItem> items)
        {            
            transaction.Item = items.Select(i => new Item
            {
                Id = i.Id.ToString(),
                Quantity = i.Quantity,
                Title = i.Product.ProductName,
                UnitPrice = (int)(i.Product.Price * 100),                
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
                exceptionStr = $@"The PagarMe Service throwed the following:Type erro:{error.Type},
                    Parameter:{error.Parameter},
                    Message:{error.Message}";                
            }
            return exceptionStr;
        }
        private Result<Card> CreateCard()
        {
            var card = new Card
            {
                Number = "4716854604523016",
                HolderName = "Test User",
                ExpirationDate = "0720",
                Cvv = "996"
            };
            try
            {
                card.Save();
            }catch(PagarMeException ex)
            {
                var errorStr = HandleErrorMessage(ex);
                return Result.Fail<Card>(errorStr,card);
            }            
            return Result.Ok(card);
        }
        private string GenerateCardHash(Card card)
        {
            var hash = new CardHash
            {
                CardCvv = card.Cvv,
                CardExpirationDate = card.ExpirationDate,
                CardHolderName = card.HolderName,
                CardNumber = card.Number
            };
            return hash.Generate();
        }
        private void MapCustomerToTransactionCustomer(Transaction transaction, CustomerDto user)
        {
            if (string.IsNullOrEmpty(transaction.Card.Id))
            {
                transaction.Customer = new PagarMe.Customer()
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
                    user.PhoneNumber
                }
                };
            } else
            {
                transaction.Customer = new PagarMe.Customer()
                {
                    Country = "br",
                    ExternalId = Guid.NewGuid().ToString(),
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
                    user.PhoneNumber
                    }
                };
            }
        }        
    }
}
