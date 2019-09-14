using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Customer.Area.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}