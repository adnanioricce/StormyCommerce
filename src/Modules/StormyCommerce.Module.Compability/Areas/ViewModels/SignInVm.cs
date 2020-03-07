using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace StormyCommerce.Module.Compability.Areas.ViewModels
{
    public class SignInVm
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [DataType(DataType.Password)]
        [DisplayName("Email Address")]
        public string Password { get; set; }  
    }
}