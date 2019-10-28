using System;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class Document
    {        
        [Required]
        public string Type { get; set; }

        [Required]
        public string Number { get; set; }
    }
}
