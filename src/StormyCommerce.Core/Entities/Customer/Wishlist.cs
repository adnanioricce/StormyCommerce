using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Wishlist : BaseEntity
    {
        public string StormyCustomerId { get; set; }
        public virtual StormyCustomer Customer { get; set; }
        public virtual ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();

        /// <summary>
        /// Adds a product available on the catalog of the store on the Wishlist
        /// </summary>
        /// <param name="productId">the Id of the product been added</param>
        public bool AddItem(long productId)
        {            
            if(!WishlistItems.Any(it => it.ProductId == productId)){
                WishlistItems.Add(new WishlistItem{
                    Wishlist = this,
                    ProductId = productId
                });
                return true;
            }
            return false;
        }

        public bool Remove(long productId)
        {
            if(WishlistItems.Any(it => it.ProductId == productId)){
                WishlistItems.Remove(this.WishlistItems.Where(i => i.ProductId == productId).FirstOrDefault());
                return true;
            }
            return false;
        }
    }
}
