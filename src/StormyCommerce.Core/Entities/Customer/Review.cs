using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos;

namespace StormyCommerce.Core.Entities
{
    public class Review : BaseEntity
    {
        public Review()
        {
        }

        public Review(CustomerReviewDto customerReview)
        {
            Id = customerReview.Id;
            Title = customerReview.Title;
            Comment = customerReview.Comment;
            ReviewerName = customerReview.ReviewerName;
            RatingLevel = customerReview.RatingLevel;
            Author = new StormyCustomer
            {
                UserName = customerReview.UserName,
                Email = customerReview.Email
            };
            Status = ReviewStatus.Approved;
        }

        public long StormyCustomerId { get; set; }
        public StormyCustomer Author { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ReviewerName { get; set; }
        public int RatingLevel { get; set; }
        public ReviewStatus Status { get; set; }
    }
}
