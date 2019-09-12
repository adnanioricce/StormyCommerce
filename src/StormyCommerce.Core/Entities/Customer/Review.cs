using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos;

namespace StormyCommerce.Core.Entities
{
    public class Review : BaseEntity
    {
        public Review(){ }
        public Review(CustomerReviewDto customerReviewDto)
        {
            Comment = customerReviewDto.Comment;
            Title = customerReviewDto.Title;
            ReviewerName = customerReviewDto.ReviewerName;
            RatingLevel = customerReviewDto.RatingLevel;            
        }
        public long StormyCustomerId { get; set; }
        public StormyCustomer Author { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ReviewerName { get; set; }
        public int RatingLevel { get; set; }
    }
}
