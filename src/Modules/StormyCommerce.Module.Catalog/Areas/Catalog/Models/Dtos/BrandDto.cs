
using SimplCommerce.Module.Catalog.Models;

namespace StormyCommerce.Module.Catalog.Models.Dtos
{
    public class BrandDto
    {
        public BrandDto(){}

        public BrandDto(Brand brand)
        {
            Name = brand.Name;
            Description = brand.Description;
            Slug = brand.Slug;
            Website = brand.Website;
        }

        public string Name { get; private set; }
        public string Description { get; set; }
        public string Slug { get; private set; }
        public string Website { get; private set; }
        //TODO:What more?
    }
}
