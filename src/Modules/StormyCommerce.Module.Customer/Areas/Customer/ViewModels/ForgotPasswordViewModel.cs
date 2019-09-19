using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Customer.Areas.Customer.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
