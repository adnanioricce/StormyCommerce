using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class PagarMeItem
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int UnitPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string Category { get; set; }

        [Required]
        public bool Tangible { get; set; }

        public string Venue { get; set; }
        public string Date { get; set; }
    }
}
