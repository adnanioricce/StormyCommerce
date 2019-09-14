﻿using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Customer.Area.ViewModels
{
    public class SignInVm
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }        
        public string Username { get; set; }                
    }
}
