using PagarMe;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PaymentMethod = PagarMe.PaymentMethod;
using PagarMe.Model;
using System;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class TransactionVm
    {
        [Required]
        public string Object { get; set; }

        [Required]
        public TransactionStatus Status { get; set; }

        public string RefuseReason { get; set; }
        public string StatusReason { get; set; }
        public string AcquirerName { get; set; }
        public string AcquirerId { get; set; }
        public string AcquirerResponseCode { get; set; }
        public string AuthorizationCode { get; set; }
        public bool Async { get; set; } 

        [StringLength(13)]
        public string SoftDescriptor { get; set; }

        public string Tid { get; set; }
        public string Nsu { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public string DateUpdated { get; set; }

        [DataType(DataType.Currency)]
        public int Amount { get; set; }

        [DataType(DataType.Currency)]
        public int AuthorizedAmount { get; set; }

        [DataType(DataType.Currency)]
        public int PaidAmount { get; set; }

        [DataType(DataType.Currency)]
        public int RefundedAmount { get; set; }

        [StringLength(12)]
        public int Installments { get; set; }

        public int Id { get; set; }

        [DataType(DataType.Currency)]
        public int Cost { get; set; }

        public string CardHolderName { get; set; }
        public string CardLastDigits { get; set; }
        public string CardFirstDigits { get; set; }
        public string CardBrand { get; set; }
        public string CardPinMode { get; set; }

        [DataType(DataType.Url)]
        public string PostbackUrl { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CaptureMethod { get; set; }
        public string AntifraudScore { get; set; }
        [DataType(DataType.Url)]
        public string BoletoUrl { get; set; }
        public string BoletoBarcode { get; set; }
        [DataType(DataType.Date)]
        public string BoletoExpirationDate { get; set; }
        public string Referer { get; set; }
        public string IP { get; set; }
        public int SubscriptionId { get; set; }
        public PagarMeCustomerVm Customer { get; set; }
        public BillingVm Billing { get; set; }
        public ShippingVm Shipping { get; set; }        
        public ShippingAddressModel Address { get; set; }
        public List<PagarMeItem> Items { get; set; }
        public List<Document> Documents { get; set; }
        //TODO:Define a metadata object
        public object Metadata { get; set; }
        public object SpliRules { get; set; }
        public object AntifraudMetadata { get; set; }
        public string Session { get; set; }
        
    }
}
