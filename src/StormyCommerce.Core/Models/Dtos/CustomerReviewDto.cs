using System;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerReviewDto
    {
        public long Id { get; private set; }
        public string Comment { get; private set; }
        public string Email { get; private set; }
        public string ReviewerName { get; private set; }
        public string Username { get; private set; }                
        public int RatingLevel { get; private set;}
    }
}
