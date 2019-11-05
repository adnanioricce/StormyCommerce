using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Module.Catalog.Dtos;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class ProductOverviewDto
    {
        public ProductOverviewDto()
        {
        }

        public ProductOverviewDto(StormyProduct product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            Slug = product.Slug;
            Price = product.Price;
            OldPrice = product.OldPrice;
            HasDiscountApplied = product.HasDiscountApplied;            
            AvailableForPreorder = product.AvailableForPreorder;
            ThumbnailImage = product.ThumbnailImage;
            Categories = product.Categories;
            Medias = product.Medias;
        }

        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string Slug { get; private set; }
        public Price Price { get; private set; }
        public Price OldPrice { get; private set; }
        public bool HasDiscountApplied { get; private set; }
        public bool AvailableForPreorder { get; private set; }
        
        public string ThumbnailImage { get; private set; }
        public List<ProductCategory> Categories { get; private set; } = new List<ProductCategory>();
        public List<ProductMedia> Medias { get; private set; } = new List<ProductMedia>();
    }
}
