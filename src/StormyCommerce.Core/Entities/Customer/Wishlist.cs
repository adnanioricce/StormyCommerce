using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Wishlist : BaseEntity
    {
        public string StormyCustomerId { get; set; }
        public StormyCustomer Customer { get; set; }
        public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();

        /// <summary>
        /// Adds a product available on the catalog of the store on the Wishlist
        /// </summary>
        /// <param name="productId">the Id of the product been added</param>
        public void AddItem(long productId)
        {
            var item = WishlistItems.FirstOrDefault(f => f.ProductId == productId);            
            if (item != null) return;

            WishlistItems.Add(new WishlistItem{
                Wishlist = this,
                ProductId = productId
            });
        }

        public void Remove(long productId)
        {
            var item = WishlistItems.FirstOrDefault(f => f.ProductId == productId);
            if (item == null) return; 
            
            WishlistItems.Remove(this.WishlistItems.Where(i => i.ProductId == productId).FirstOrDefault());
        }
    }
}
