using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using StormyCommerce.Core.Entities.Shipping;

namespace StormyCommerce.Core.Models.Order
{
    public class BoletoCheckoutRequest : IValidatableObject
    {
        [Required]
        [Range(1,9999999)]
        public decimal Amount { get; set; }
        public string PaymentMethod { get; } = "boleto";
        public ShippingMethod ShippingMethod { get; set; }
        public bool PickUpOnStore { get; set; }
        [Required]
        public List<CartItem> Items { get; set; }        
        public string PostalCode { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!(this.Amount >= 1)) 
            {
                yield return new ValidationResult("A transaction minimal value is R$1");
            }
            if(!(this.Items.Count > 0 && this.Items.All(i => i.Quantity > 0)))
            {
                yield return new ValidationResult("You can't order a item with 0 products or create a order with 0 items");
            }
            //if()
        }
    }
}
