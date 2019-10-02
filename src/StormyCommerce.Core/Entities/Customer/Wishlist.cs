using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Wishlist : BaseEntity
    {
        public int CustomerId { get; set; }
        public StormyCustomer Customer { get; set; }
        public ICollection<WishlistItem> WishlistItems { get; set; }

        /// <summary>
        /// Adds a product available on the catalog of the store on the Wishlist
        /// </summary>
        /// <param name="productId">the Id of the product been added</param>
        public void AddItem(int productId)
        {
            var item = WishlistItems.FirstOrDefault(f => f.ProductId == productId);
            //?Should this be a more loud return?Throw a exception maybe
            if (item != null)
                return;

            WishlistItems.Add(item);
        }

        public void Remove(WishlistItem wishlistItem)
        {
            var item = WishlistItems.FirstOrDefault(f => f.ProductId == wishlistItem.Id);
            if (item != null)
                WishlistItems.Remove(item);
        }
    }
}
