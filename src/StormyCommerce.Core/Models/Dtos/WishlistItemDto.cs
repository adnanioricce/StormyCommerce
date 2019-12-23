using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Models.Dtos
{
    public class WishListItemDto
    {
        public WishListItemDto(WishlistItem item)
        {
            this.Product = item.Product == null ? this.Product : item.Product.ToProductDto();
        }
        public ProductDto Product { get; private set; } = new ProductDto();
    }
}
