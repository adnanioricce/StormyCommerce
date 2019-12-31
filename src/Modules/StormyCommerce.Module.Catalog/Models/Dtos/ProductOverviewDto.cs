using System.Collections.Generic;
using System.Linq;
using SimplCommerce.Module.Catalog.Models;

namespace StormyCommerce.Module.Catalog.Models.Dtos
{
    public class ProductOverviewDto
    {
        public ProductOverviewDto() { }        

        public ProductOverviewDto(Product product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            Slug = product.Slug;
            Price = Price.GetPriceFromString(product.Price);            
            ThumbnailImage = product.ThumbnailImage;
            Categories = product.Categories.Select(c => new ProductCategoryDto(c)).ToList();
            Medias = product.Medias;
        }

        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string Slug { get; private set; }
        public Price Price { get; private set; }                
        public string ThumbnailImage { get; private set; }
        public List<ProductCategoryDto> Categories { get; private set; } = new List<ProductCategoryDto>();
        public List<ProductMedia> Medias { get; private set; } = new List<ProductMedia>();
    }
}
