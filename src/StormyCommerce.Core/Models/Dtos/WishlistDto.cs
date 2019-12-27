using System.Collections.Generic;
using System.Linq;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Models.Dtos
{
    public class WishlistDto
    {
        public WishlistDto()
        {

        }
        public WishlistDto(Wishlist wishlist)
        {
            Items = wishlist.Items.Select(i => new WishListItemDto(i)).ToList();
        }
        public ICollection<WishListItemDto> Items { get; set; } = new List<WishListItemDto>();
    }
}
