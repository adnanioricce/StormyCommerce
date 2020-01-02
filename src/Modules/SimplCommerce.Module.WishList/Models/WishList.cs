using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.WishList.Models
{
    public class WishList : EntityBase
    {
        public WishList()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public long UserId { get; set; }

        public User User { get; set; }

        [StringLength(450)]
        public string SharingCode { get; set; }

        public IList<WishListItem> Items { get; protected set; } = new List<WishListItem>();

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }
		/// <summary>
        /// Adds a product available on the catalog of the store on the Wishlist
        /// </summary>
        /// <param name="productId">the Id of the product been added</param>
        public bool AddItem(long productId)
        {            
            if(!Items.Any(it => it.ProductId == productId)){
                Items.Add(new WishListItem{
                    WishList = this,
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
