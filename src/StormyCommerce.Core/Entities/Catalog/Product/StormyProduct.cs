using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class StormyProduct : BaseEntity
    {
        public StormyProduct(long id)
        {
            Id = id;
        }
        public StormyProduct(ProductDto productDto)
        {
            Id = productDto.Id;
            Slug = productDto.Slug;
            ProductName = productDto.ProductName;
            OldPrice = productDto.OldPrice;
            Price = productDto.Price;
            QuantityPerUnity = productDto.QuantityPerUnity;
            UnitPrice = productDto.UnitPrice;
            UnitsInStock = productDto.UnitsInStock;
            UnitSize = Convert.ToDecimal(productDto.UnitSize);
            UnitsOnOrder = productDto.UnitsOnOrder;
            UnitWeight = productDto.UnitWeight;
            ThumbnailImage = productDto.ThumbnailImage;
        }
        public StormyProduct(ProductDto productDto, long id) : this(productDto)
        {
            Id = id;
        }
        public StormyProduct(){}

        public string SKU { get; set; }
        public string Gtin { get; set; }
        public string NormalizedName { get; set; }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public long CreatedById { get; set; }
        public long BrandId { get; set; }
        public long MediaId { get; set; }
        public long VendorId { get; set; }
        public long CategoryId { get; set; }
        public long? ProductLinksId { get; set; }
        public long? TaxClassId { get; set; }
        public long? LatestUpdatedById { get; set; }
        public StormyVendor Vendor { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public string TypeName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public int QuantityPerUnity { get; set; }
        public decimal UnitSize { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public double UnitWeight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int? Diameter { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReviewsCount { get; set; }
        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public bool StockTrackingIsEnabled { get; set; } = true;
        public string ThumbnailImage { get; set; }
        public List<Media.Media> Medias { get; protected set; } = new List<Media.Media>();
        public List<ProductLink> Links { get; protected set; } = new List<ProductLink>();
        public List<ProductLink> LinkedProductLinks { get; protected set; } = new List<ProductLink>();
        public List<ProductAttribute> ProductAttributes { get; set; }
        public List<ProductAttributeValue> AttributeValues { get; protected set; } = new List<ProductAttributeValue>();
        public List<ProductOptionValue> OptionValues { get; protected set; } = new List<ProductOptionValue>();
        public int Ranking { get; set; }
        public string Note { get; set; }
        public string Price { get; set; }
        public string OldPrice { get; set; }
        public string SpecialPrice { get; set; }
        public DateTime? SpecialPriceStart { get; set; }
        public DateTime? SpecialPriceEnd { get; set; }        
        public bool HasDiscountApplied { get; set; }
        public bool IsPublished { get; set; }
        public string Status { get; set; }
        public bool NotReturnable { get; set; }
        public bool AvailableForPreorder { get; set; }
        public bool HasOptions { get; set; }
        public bool IsVisibleIndividually { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsCallForPricing { get; set; }
        public bool IsAllowToOrder { get; set; }        
        public decimal ProductCost { get; set; }
        public DateTime? PreOrderAvailabilityStartDate { get; set; }
        public DateTime? PublishedOn { get; set;}
        public DateTime? CreatedOn { get; set; }
        public DateTime? LatestUpdatedOn { get; set; }
        public bool AllowCustomerReview { get; set; }
        public int ApprovedRatingSum { get; set; }
        public int NotApprovedRatingSum { get; set; }
        public int ApprovedTotalReviews { get; set; }
        public int NotApprovedTotalReviews { get; set; }
        public int RatingAverage { get; set; }        
        public void AddMedia(Media.Media media)
        {
            Medias.Add(media);
        }

        public void AddAttributeValue(ProductAttributeValue attributeValue)
        {
            attributeValue.Product = this;
            AttributeValues.Add(attributeValue);
        }

        public void AddOptionValue(ProductOptionValue optionValue)
        {
            optionValue.Product = this;
            OptionValues.Add(optionValue);
        }

        public void AddProductLinks(ProductLink productLink)
        {
            productLink.Product = this;
            Links.Add(productLink);
        }

        public ProductDto ToProductDto(StormyProduct product)
        {
            return new ProductDto(this);
        }

        public List<MediaDto> ToMediasDtos()
        {
            var medias = this.Medias;
            return medias.Select(media => media.ToMediaDto()).ToList();
        }
        public int CalculateDimensions()
        {
            //TODO:Calculate products with diameter
            return this.Width * this.Height; 
        }
    }
}
