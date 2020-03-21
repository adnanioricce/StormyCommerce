using System;
using System.Collections.Generic;
using System.Linq;

using PagarMe;
using SimplCommerce.Infrastructure.Models;
using SimplCommerce.Module.Payments.Models;
using PagarMeShipping = PagarMe.Shipping;
namespace SimplCommerce.Module.PagarMe.Services
{
    public class PagarMeWrapper
    {
        private readonly PagarMeService _service;
        public PagarMeWrapper(PagarMeService service)
        {
            _service = service;
        }
        public virtual Transaction Charge(ProcessTransactionRequest request)
        {
            var method = CheckPaymentMethod(request.PaymentMethod);
            if (method == PaymentMethod.Boleto) return ChargeBoleto(request);
            if (method == PaymentMethod.CreditCard) return ChargeCredit(request);
            if (method == PaymentMethod.DebitCard) return new Transaction();
            return new Transaction();
        }
        private Transaction ChargeCredit(ProcessTransactionRequest request)
        {
            var transaction = new Transaction();
            return transaction;
            
        }
        private Transaction ChargeBoleto(ProcessTransactionRequest request)
        {
            var transaction = CreateBoletoTransaction(request);
            try
            {
                transaction.Save();
                return transaction;
            }
            catch (PagarMeException ex)
            {
                string exceptionStr = HandleErrorMessage(ex);
                throw new Exception(exceptionStr);
            }
        }
        private Transaction CreateBoletoTransaction(ProcessTransactionRequest request)
        {            
            var transaction = new Transaction();
            transaction.Amount = ConvertToCents(request.TotalAmount);
            transaction.PaymentMethod = PaymentMethod.Boleto;     
            transaction.Customer = new Customer()
            {
                ExternalId = request.User.UserGuid.ToString(),
                Country = request.User.Culture.ToLower(),
                Type = CustomerType.Individual,
                Name = request.User.FullName,
                Email = request.User.Email,
                Documents = request.User.GetData<IEnumerable<UserDocument>>("Documents").Select(d => new Document
                {
                    Type = d.Type == "cnpj" ? DocumentType.Cnpj : DocumentType.Cpf,
                    Number = d.Value
                }).ToArray(),
                PhoneNumbers = new string[]{
                    request.User.PhoneNumber
                }
            };            
            transaction.Item = request.Items.Select(i => new Item
            {
                Id = i.Id.ToString(),
                Quantity = i.Quantity,
                Title = i.Product.Name,
                UnitPrice = ConvertToCents(i.Product.Price),
                Tangible = true
            }).ToArray();
            return transaction;
        }
        private Transaction CreateCreditCardTransaction(ProcessTransactionRequest request)
        {
            Transaction transaction = new Transaction();
            //TODO:Generate card hash
            //TODO:get shipping and billing information
            //TODO: pass all data to transaction object;
            return transaction;
        }
        private PaymentMethod CheckPaymentMethod(string paymentMethod)
        {
            return paymentMethod == "boleto"
                ? PaymentMethod.Boleto : paymentMethod == "credit_card"
                ? PaymentMethod.CreditCard : paymentMethod == "debit_card"
                ? PaymentMethod.DebitCard : PaymentMethod.CreditCard;
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
        private int ConvertToCents(decimal value )
        {
            return Convert.ToInt32((value * 100)
                .ToString()
                .Replace(",", string.Empty)
                .Replace(".", string.Empty));
        }
    }
}
