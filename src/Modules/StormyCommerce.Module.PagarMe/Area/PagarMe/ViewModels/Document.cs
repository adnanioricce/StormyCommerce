using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class Document
    {
        [Required]
        public int Type { get; set; }

        [Required]
        public string Number { get; set; }
    }
}
