namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductLink : BaseEntity
    {
        public long ProductId { get; set; }

        public StormyProduct Product { get; set; }

        public long LinkedProductId { get; set; }

        public StormyProduct LinkedProduct { get; set; }

        public ProductLinkType LinkType { get; set; }
    }
}
