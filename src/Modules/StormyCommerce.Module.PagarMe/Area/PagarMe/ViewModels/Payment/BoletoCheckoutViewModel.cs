using PagarMe;
using StormyCommerce.Core.Entities.Customer;
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
        
        public ShippingVm Shipping { get; set; }    
        [Required]    
        public string ShippingMethod { get; set; }
        public List<PagarMeItem> Items { get; set; }
        public StormyCommerce.Module.PagarMe.Models.PaymentMethod PaymentMethod { get; } = StormyCommerce.Module.PagarMe.Models.PaymentMethod.Boleto;
        
        public TransactionVm ToTransactionVm(StormyCustomer customer)
        {
            return new TransactionVm{
                Amount = this.Amount,                
                Billing = this.Billing,
                Shipping = this.Shipping,
                Items = this.Items,
                PaymentMethod = this.PaymentMethod,
                Customer = new PagarMeCustomerVm {
                ExternalId = customer.UserId,
                    Name = customer.FullName,
                    Type = (int)CustomerType.Individual,
                    Country = "br",
                    Email = customer.Email,
                    Documents = new System.Collections.Generic.List<ViewModels.Document>{
                        new ViewModels.Document{
                            Type = (int)DocumentType.Cpf,
                            Number = customer.CPF,
                        }
                    }                
                }
            };
        }
    }
}
