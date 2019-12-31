
using System.Collections.Generic;
using SimplCommerce.Module.Payments.Models;
using StormyCommerce.Core.Models.Dtos;

namespace StormyCommerce.Module.Payments.Models.Requests
{
    public class ProcessPaymentRequest
    {
        public ProcessPaymentRequest(){}
        public ProcessPaymentRequest(CheckoutBoletoRequest request,List<OrderItemDto> items,CustomerDto customer)
        {
            Amount = (int)(request.Amount * 100);
            Items = items;
            Customer = customer;
            PaymentMethod = request.PaymentMethod;
            PickUpOnStore = request.PickUpOnStore;
            PaymentMethod = PaymentMethod.CreditCard;
        }
        public ProcessPaymentRequest(CheckoutCreditCardRequest request, List<OrderItemDto> items, CustomerDto customer)
        {
            Amount = (int)(request.Amount * 100);
            PaymentMethod = PaymentMethod.CreditCard;
            CardCvv = request.CardCvv;
            CardExpirationDate = request.CardExpirationDate;
            CardHolderName = request.CardHolderName;
            CardNumber = request.CardNumber;
            Customer = customer;
            Items = items;
            PostalCode = request.PostalCode;
            PickUpOnStore = request.PickUpOnStore;
        }
        public int Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<OrderItemDto> Items { get; set; }
        public CustomerDto Customer { get; set; }
        public bool PickUpOnStore { get; set; }        
        public string PostalCode { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CardExpirationDate { get; set; }
        public string CardCvv { get; set; }
    }
}
