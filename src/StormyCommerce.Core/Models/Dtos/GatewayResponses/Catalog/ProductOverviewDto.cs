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
            IsPublished = product.IsPublished;
            AvailableForPreorder = product.AvailableForPreorder;
            ThumbnailImage = product.ThumbnailImage;
            Category = new CategoryDto(product.Category);
            Medias = product.Medias;
        }

        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string Slug { get; private set; }
        public Price Price { get; private set; }
        public Price OldPrice { get; private set; }
        public bool HasDiscountApplied { get; private set; }
        public bool IsPublished { get; private set; }
        public bool AvailableForPreorder { get; private set; }

        //Maybe this will be more hard to make...
        public string ThumbnailImage { get; private set; }

        public CategoryDto Category { get; private set; } = new CategoryDto();
        public List<ProductMedia> Medias { get; private set; } = new List<ProductMedia>();
    }
}
