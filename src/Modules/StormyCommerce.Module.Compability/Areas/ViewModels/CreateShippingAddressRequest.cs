using System.ComponentModel.DataAnnotations;
namespace StormyCommerce.Module.Compability.Areas.ViewModels
{
    public class CreateShippingAddressRequest
    {
        [Required]
        public Address Address { get; set; }
        public string WhoReceives { get; set; }
        [Required]
        public bool IsBillingAddress { get; set; }
    }
}