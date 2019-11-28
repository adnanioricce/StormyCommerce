using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Models.Dtos
{
    public class WishListItemDto
    {
        public WishListItemDto(WishlistItem item)
        {
            this.Product = item.Product.ToProductDto();
        }
        public ProductDto Product { get; set; }
    }
}
