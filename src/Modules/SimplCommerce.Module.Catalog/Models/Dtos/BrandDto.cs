
namespace SimplCommerce.Module.Catalog.Models.Dtos
{
    public class BrandDto
    {
        public BrandDto()
        {
        }

        public BrandDto(Brand brand)
        {
            Name = brand.Name;
            Slug = brand.Slug;
            Website = brand.Website;
        }

        public string Name { get; private set; }
        public string Slug { get; private set; }
        public string Website { get; private set; }
        //TODO:What more?
    }
}
