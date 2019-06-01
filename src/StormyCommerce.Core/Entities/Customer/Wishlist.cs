using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Wishlist : BaseEntity
    {
        public ICollection<WishlistItem> MyProperty { get; set; }
    }
}
