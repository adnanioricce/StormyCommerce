
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Comment : EntityBase
    {
        public Comment(){}
        public string Title { get; set; }
        public string Body { get; set; }
        public long ProductId { get; set; }
        public virtual StormyProduct Product { get; set; }
        public long UserId { get; set; }
        public virtual StormyUser User { get; set; }        
    }
}
