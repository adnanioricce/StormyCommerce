using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Customer.Areas.Customer.ViewModels
{
    public class CreateCustomerRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}