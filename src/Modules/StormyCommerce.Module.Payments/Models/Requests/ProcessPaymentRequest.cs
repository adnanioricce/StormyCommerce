
using System;
using System.Collections.Generic;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Module.ShoppingCart.Models;
using StormyCommerce.Core.Models.Dtos;

namespace StormyCommerce.Module.Payments.Models.Requests
{
    public class ProcessPaymentRequest
    {
        public ProcessPaymentRequest(){}
        public ProcessPaymentRequest(CheckoutBoletoRequest request,List<CartItem> items,CustomerDto customer)
        {
            Amount = (int)(request.Amount * 100);
            Items = items;
            Customer = customer;
            PaymentMethod = request.PaymentMethod;
            PickUpOnStore = request.PickUpOnStore;
            PaymentMethod = PaymentMethod.CreditCard;
        }
        public ProcessPaymentRequest(CheckoutCreditCardRequest request, List<CartItem> items, CustomerDto customer)
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
        public string GatewayTransactionId { get; set; }
        public int Amount { get; set; }
        public int Cost { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<CartItem> Items { get; set; }
        public CustomerDto Customer { get; set; }
        public bool PickUpOnStore { get; set; }        
        public string PostalCode { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CardExpirationDate { get; set; }
        public string CardCvv { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? ExpirationDate { get; set; }
        public string BoletoUrl { get; set; }
        public string BoletoBarcode { get; set; }

    }
}
