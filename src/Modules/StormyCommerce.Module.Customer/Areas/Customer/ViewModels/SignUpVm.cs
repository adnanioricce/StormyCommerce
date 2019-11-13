using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Customer.Areas.Customer.ViewModels
{
    public class SignUpVm
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }        
        public string UserName { get; set; }
    }
}
