using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Entities
{
    public class Review : BaseEntity
    {
        public long StormyCustomerId { get; set; }
        public StormyCustomer Author { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ReviewerName { get; set; }
        public int RatingLevel { get; set; }
    }
}
