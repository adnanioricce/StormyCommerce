using StormyCommerce.Core.Entities.Product;
using StormyCommerce.Core.Entities.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
	public class StormyProduct : BaseEntity
	{
		public string SKU { get; set;}				
		public string ProductName { get; set; }
        public string Slug { get; set; }
        public long BrandId { get; set; }	       
        public long MediasId { get; set; }
        public long VendorId { get; set; }     
        public long ProductLinksId { get; set; }        
        public StormyVendor Vendor {get;set;}
        public Brand Brand { get; set; }
		public string TypeName { get; set; }
		public int QuantityPerUnity {get;set;}	            		
		public string UnitSize {get;set;}
		public decimal UnitPrice {get;set;}
		public decimal Discount {get;set;}
		public double UnitWeight {get;set;}
		public int UnitsInStock {get;set;}
		public int UnitsOnOrder {get;set;}
		public bool ProductAvailable {get;set;}
		public bool DiscountAvailable {get;set;}
		public bool CurrentOrder {get; set;}
        public List<Media.Media> Medias { get; protected set; }
        public List<ProductLink> Links { get; protected set; } = new List<ProductLink>();
        public List<ProductLink> LinkedProductLinks { get; protected set; } = new List<ProductLink>();
        public List<ProductAttribute> ProductAttributes { get; set;}	
        public List<ProductAttributeValue> AttributeValues { get; protected set; } = new List<ProductAttributeValue>();
        public List<ProductOptionValue> OptionValues { get; protected set; } = new List<ProductOptionValue>();
        public int Ranking {get;set;}
		public string Note {get;set;}
		public decimal Price {get;set;}
        public decimal OldPrice { get; set; }
	    public bool HasDiscountApplied { get; set; }
        public bool Deleted { get; set; }
	    public bool Published { get; set; }        
	    public string Status {get;set;}
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
    }
}
