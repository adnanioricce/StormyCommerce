﻿using StormyCommerce.Core.Entities.Catalog.Product;
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
            Medias = product.ToMediasDtos();
        }

        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string Slug { get; private set; }
        public string Price { get; private set; }
        public string OldPrice { get; private set; }
        public bool HasDiscountApplied { get; private set; }
        public bool IsPublished { get; private set; }
        public bool AvailableForPreorder { get; private set; }

        //Maybe this will be more hard to make...
        public string ThumbnailImage { get; private set; }

        public CategoryDto Category { get; private set; } = new CategoryDto();
        public List<MediaDto> Medias { get; private set; } = new List<MediaDto>();
    }
}
