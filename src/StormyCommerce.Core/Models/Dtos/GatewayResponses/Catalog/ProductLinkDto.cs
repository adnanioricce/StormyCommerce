using StormyCommerce.Core.Entities.Catalog.Product;
namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class ProductLinkDto
    {
        public ProductLinkDto(ProductLink productLink)
        {
            Product = productLink.Product.ToProductDto();
            LinkedProduct = productLink.LinkedProduct.ToProductDto();
            LinkType = productLink.LinkType;
        }
        public ProductDto Product { get; private set; }
        public ProductDto LinkedProduct { get; private set; }
        public ProductLinkType LinkType { get; private set; }
    }
}
