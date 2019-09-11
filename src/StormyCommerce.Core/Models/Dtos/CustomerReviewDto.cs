using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerReviewDto
    {
        public CustomerReviewDto() {}        
        public CustomerReviewDto(Review review)
        {
            Comment = review.Comment;
            Email = review.Author.Email;
            ReviewerName = review.ReviewerName;
            RatingLevel = review.RatingLevel;
            Title = review.Title;
            UserName = review.Author.UserName;
        }
        public long Id { get; private set; }
        public string Title { get; set; }
        public string Comment { get; private set; }
        public string Email { get; private set; }
        public string ReviewerName { get; private set; }
        public string UserName { get; private set; }
        public int RatingLevel { get; private set; }
    }
}
