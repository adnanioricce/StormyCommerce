using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class BrandDto
    {
        public BrandDto(Brand brand)
        {
            Name = brand.Name;
            Slug = brand.Slug;
            Website = brand.Website;
        }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Website { get; set; }
        //TODO:What more?

    }
}
