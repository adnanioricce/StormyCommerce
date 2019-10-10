using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Module.PagarMe.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class BoletoCheckoutViewModel
    {
        [Required]
        public int Amount { get; set; }
        [Required]
        public string CustomerFullName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }        
        [Required]
        public BillingVm Billing { get; set; }
        [Required]
        public ShippingVm Shipping { get; set; }        
        public List<PagarMeItem> Items { get; set; }
        public PaymentMethod PaymentMethod { get; } = PaymentMethod.Boleto;
        
        public TransactionVm ToTransactionVm(PagarMeCustomerVm customer)
        {
            return new TransactionVm{
                Amount = this.Amount,
                Customer = customer,
                Billing = this.Billing,
                Shipping = this.Shipping,
                Items = this.Items,
                PaymentMethod = this.PaymentMethod                
            };
        }
    }
}
