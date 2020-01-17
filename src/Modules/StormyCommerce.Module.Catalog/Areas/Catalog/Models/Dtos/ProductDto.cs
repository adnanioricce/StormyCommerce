using System;
using System.Collections.Generic;
using System.Linq;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Module.Catalog.Models.Dtos;

namespace StormyCommerce.Module.Catalog.Models.Dtos
{
    public class ProductDto
    {
        public ProductDto(){}

        public ProductDto(Product product, long id) : this(product)
        {
            Id = id;                       
        }

        public ProductDto(Product product)
        {
            Id = product.Id;                                    
            Sku = product.Sku;
            Gtin = product.Gtin;            
            HasOptions = product.HasOptions;
            IsVisibleIndividually = product.IsVisibleIndividually;
            IsFeatured = product.IsFeatured;
            IsAllowToOrder = product.IsAllowToOrder;
            IsCallForPricing = product.IsCallForPricing;            
            StockTrackingIsEnabled = product.StockTrackingIsEnabled;                        
            DisplayOrder = product.DisplayOrder;                        
            Name = product.Name;
            NormalizedName = product.NormalizedName;
            Slug = product.Slug;            
            ShortDescription = product.ShortDescription;
            Description = product.Description;
            Specification = product.Specification;
            Height = product.Height;
            Width = product.Width;
            Length = product.Length;            
            UnitWeight = product.UnitWeight;
            StockQuantity = product.StockQuantity;
            UnitsOnOrder = product.UnitsOnOrder;                  
            Price = product.Price;            
            OldPrice = product.OldPrice;
            SpecialPrice = product.SpecialPrice;
            SpecialPriceStart = product.SpecialPriceStart;
            SpecialPriceEnd = product.SpecialPriceEnd;
            ThumbnailImage = product.ThumbnailImage.FileName;
            Medias = product.Medias.Select(m => new ProductMediaDto(m)).ToList();
            Categories = product.Categories.Select(c => new ProductCategoryDto(c)).ToList();
            Brand = product.Brand == null ? this.Brand : new BrandDto(product.Brand);                                   
        }

        public long Id { get; private set; }
        public int DisplayOrder { get; private set; }
        public string Sku { get; private set; }
        public string Gtin { get; private set; }
        public string Name { get; private set; }        
        public string NormalizedName { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Specification { get; private set; }
        public bool ProductAvailable { get; private set; }
        public bool StockTrackingIsEnabled { get; private set; }
        public bool IsPublished { get; private set; }        
        public bool IsFeatured { get; private set; }
        public bool HasOptions { get; private set; }                
        public bool IsCallForPricing { get; private set; }
        public bool IsAllowToOrder { get; private set; }
        public bool IsVisibleIndividually { get; private set; }                
        public string Slug { get; private set; }          
        public decimal? SpecialPrice { get; private set; }    
        public double? Height { get; private set; }
        public double? Width { get; private set; }
        public double? Length { get; private set; }
        public double? UnitWeight { get; private set; }
        public int StockQuantity { get; private set; }
        public int? UnitsOnOrder { get; private set; }
        public decimal Price { get; private set; }
        public decimal? OldPrice { get; private set; }
        public string ThumbnailImage { get; private set; }
        public List<ProductCategoryDto> Categories { get; private set; } = new List<ProductCategoryDto>();
        public BrandDto Brand { get; private set; }        
        public List<ProductMediaDto> Medias { get; private set; }
        public DateTimeOffset? SpecialPriceStart { get; private set; }
        public DateTimeOffset? SpecialPriceEnd { get; private set; }

        public Product ToStormyProduct()
        {
            var product = new Product
            {                                                 
                Sku = this.Sku,
                Gtin = this.Gtin,            
                HasOptions = this.HasOptions,
                IsVisibleIndividually = this.IsVisibleIndividually,
                IsFeatured = this.IsFeatured,
                IsAllowToOrder = this.IsAllowToOrder,
                IsCallForPricing = this.IsCallForPricing,            
                StockTrackingIsEnabled = this.StockTrackingIsEnabled,                       
                DisplayOrder = this.DisplayOrder,                       
                Name = this.Name,
                NormalizedName = this.NormalizedName,
                Slug = this.Slug,            
                ShortDescription = this.ShortDescription,
                Description = this.Description,
                Specification = this.Specification,
                Height = this.Height,
                Width = this.Width,
                Length = this.Length,            
                UnitWeight = this.UnitWeight,
                StockQuantity = this.StockQuantity,
                UnitsOnOrder = this.UnitsOnOrder,                  
                Price = this.Price,            
                OldPrice = this.OldPrice,
                SpecialPrice = this.SpecialPrice,
                SpecialPriceStart = this.SpecialPriceStart,
                SpecialPriceEnd = this.SpecialPriceEnd,
                ThumbnailImage = new Media{ FileName = this.ThumbnailImage},                
                Brand = this.Brand == null ? null : new Brand {
                    Slug = this.Brand.Slug,
                    Name = this.Brand.Name,                    
                    Description = this.Brand.Description,
                    Website = this.Brand.Website
                    }    
            };
            product.AddCategoryCollection(this.Categories.Select(c => new ProductCategory{ 
                    CategoryId = c.Category.Id.Value                    
                    }));                                  
            return product;
        }
    }
}
