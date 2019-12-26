using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Entities.Media;
namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductLink : EntityBase
    {
        public long ProductId { get; set; }

        public virtual StormyProduct Product { get; set; }

        public long LinkedProductId { get; set; }

        public virtual StormyProduct LinkedProduct { get; set; }

        public ProductLinkType LinkType { get; set; }
        public ProductLinkDto ToProductLinkDto(){
            return new ProductLinkDto(this);
        }
    }
}
