
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Comment : BaseEntity
    {
        public Comment(){}
        public string Title { get; set; }
        public string Body { get; set; }
        public long ProductId { get; set; }
        public virtual StormyProduct Product { get; set; }
        public string StormyCustomerId { get; set; }
        public virtual StormyCustomer Customer { get; set; }        
    }
}
