using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Wishlist : EntityBase
    {
        public long UserId { get; set; }
        public string SharingCode { get; set; }
        public virtual StormyUser User { get; set; }
        public virtual ICollection<WishlistItem> Items { get; set; } = new List<WishlistItem>();        

        /// <summary>
        /// Adds a product available on the catalog of the store on the Wishlist
        /// </summary>
        /// <param name="productId">the Id of the product been added</param>
        public bool AddItem(long productId)
        {            
            if(!Items.Any(it => it.ProductId == productId)){
                Items.Add(new WishlistItem{
                    Wishlist = this,
                    ProductId = productId
                });
                return true;
            }
            return false;
        }

        public bool Remove(long productId)
        {
            if(Items.Any(it => it.ProductId == productId)){
                Items.Remove(this.Items.Where(i => i.ProductId == productId).FirstOrDefault());
                return true;
            }
            return false;
        }
    }
}
