using StormyCommerce.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class BillingVm
    {
        [Required]
        // [DataType(DataType.Custom)]
        public ShippingAddressModel Address { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
