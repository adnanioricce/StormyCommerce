using StormyCommerce.Core.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class ShippingVm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Fee { get; set; }

        public string DeliveryDate { get; set; }
        public bool expedited { get; set; }

        [Required]
        public Address Address { get; set; }
    }
}
