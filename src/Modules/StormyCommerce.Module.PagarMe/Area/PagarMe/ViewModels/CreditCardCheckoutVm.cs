using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class CreditCardCheckoutVm
    {
        [Required]
        [DataType(DataType.Currency)]
        public int Amout { get; set; }
        [Required]
        // [DataType(DataType.CreditCard)]
        public string CardHash { get; set; }
        [Required]        
        public string CardId { get; set; }
        [Required]
        public string CardHolderName { get; set; }
        [Required]
        public string CardExpirationDate { get; set; }
        [Required]
        [DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }
        [Required]        
        public string CardCvv { get; set; }
        [Required]
        public string PaymentMethod { get; set; } = "credit_card";
    }
}
