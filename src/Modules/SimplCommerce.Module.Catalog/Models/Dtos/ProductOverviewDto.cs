using System.Collections.Generic;
using System.Linq;
using StormyCommerce.Core.Models;

namespace SimplCommerce.Module.Catalog.Models.Dtos
{
    public class ProductOverviewDto
    {
        public ProductOverviewDto() { }        

        public ProductOverviewDto(Product product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            Slug = product.Slug;
            Price = Price.GetPriceFromCents("R$",product.Price);            
            ThumbnailImage = product.ThumbnailImage.FileName;
            Categories = product.Categories.Select(c => new ProductCategoryDto(c)).ToList();
            Medias = product.Medias;
        }

        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string Slug { get; private set; }
        public Price Price { get; private set; }                
        public string ThumbnailImage { get; private set; }
        public IList<ProductCategoryDto> Categories { get; private set; } = new List<ProductCategoryDto>();
        public IList<ProductMedia> Medias { get; private set; } = new List<ProductMedia>();
    }
}
