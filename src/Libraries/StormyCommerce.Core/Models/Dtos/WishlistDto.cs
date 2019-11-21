using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos
{
    public class WishlistDto
    {
        public ICollection<WishListItemDto> Items { get; set; }
    }
}