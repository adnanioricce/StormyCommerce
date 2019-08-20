using StormyCommerce.Core.Entities.Product;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
	public class StormyProduct : BaseEntity
	{
        public StormyProduct(int id) 
        {
            Id = id;
        }
        public StormyProduct(ProductDto productDto)
        {
            Slug = productDto.Slug;
            ProductName = productDto.ProductName;
            OldPrice = productDto.OldPrice;
            Price = productDto.Price;
            QuantityPerUnity = productDto.QuantityPerUnity;
            UnitPrice = productDto.UnitPrice;
            UnitsInStock = productDto.UnitsInStock;
            UnitSize = productDto.UnitSize;
            UnitsOnOrder = productDto.UnitsOnOrder;
            UnitWeight = productDto.UnitWeight;
            
        }
        public StormyProduct()
        {

        }
		public string SKU { get; set;}				
		public string ProductName { get; set; }
        public string Slug { get; set; }
        public long BrandId { get; set; }	       
        public long MediaId { get; set; }
        public long VendorId { get; set; }     
        public long CategoryId { get; set; }        
        public long ProductLinksId { get; set; }                
        public StormyVendor Vendor { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
		public string TypeName { get; set; }
        //QuantityPerUnity? Why I put this here
		public int QuantityPerUnity { get; set; }	            		
		public string UnitSize { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Discount { get; set; }
		public double UnitWeight  {get; set; }
		public int UnitsInStock { get; set; }
		public int UnitsOnOrder { get; set; }
		public bool ProductAvailable { get; set; }
		public bool DiscountAvailable { get; set; }
        public bool StockTrackingIsEnabled { get; set; } = true;
        public Media.Media ThumbnailImage { get; set; }
        public List<Media.Media> Medias { get; protected set; } = new List<Media.Media>();
        public List<ProductLink> Links { get; protected set; } = new List<ProductLink>();
        public List<ProductLink> LinkedProductLinks { get; protected set; } = new List<ProductLink>();
        public List<ProductAttribute> ProductAttributes { get; set;}	
        public List<ProductAttributeValue> AttributeValues { get; protected set; } = new List<ProductAttributeValue>();
        public List<ProductOptionValue> OptionValues { get; protected set; } = new List<ProductOptionValue>();
        public int Ranking { get; set;}
		public string Note { get; set;}
		public string Price { get; set;}
        public string OldPrice { get; set; }
	    public bool HasDiscountApplied { get; set; }       
	    public bool Published { get; set; }        
	    public string Status { get; set; }
	    public bool NotReturnable { get; set; }
	    public bool AvailableForPreorder { get; set; }
	    public decimal ProductCost { get; set; }
        public DateTime? PreOrderAvailabilityStartDate { get; set; }
	    public DateTime CreatedAt {get;set;}
        public DateTime UpdatedOnUtc { get; set; }
	    public bool AllowCustomerReview { get; set; }
        public int ApprovedRatingSum { get; set; }
	    public int NotApprovedRatingSum { get; set; }
	    public int ApprovedTotalReviews { get; set; }
	    public int NotApprovedTotalReviews { get; set; }        
			
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
        public ProductDto ToProductDto()
        {
            return new ProductDto(this);
        }        
        public List<MediaDto> ToMediasDtos()
        {
            var medias = this.Medias;
            return medias.Select(media => media.ToMediaDto()).ToList();
        }
    }
}
