using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Customer.Models.Requests
{
    public class WriteReviewRequest
    {
        [Required]
        public string Title { get; set; }        
        [Required]
        public string Comment { get; set; }
        [Required]
        public RatingLevel Rating { get; set; }
        public string ReviewerName { get; set; }        
        public long StormyProductId { get; set; }
    }
}
