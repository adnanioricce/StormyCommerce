using StormyCommerce.Core.Entities.Vendor;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormyCommerce.Core.Entities.Product
{
	public class StormyProduct : BaseEntity
	{
		public string SKU { get; set;}				
		public string ProductName { get; set; }        
        	public int BrandId { get; set; }
	        [NotMapped]
        	public Brand Brand { get; set; }
		public string TypeName { get; set; }
		public int QuantityPerUnity {get;set;}
	        public int VendorId { get; set; }
        	[NotMapped]
		public StormyVendor Vendor {get;set;}
		public string UnitSize {get;set;}
		public decimal UnitPrice {get;set;}
		public decimal Discount {get;set;}
		public double UnitWeight {get;set;}
		public int UnitsInStock {get;set;}
		public int UnitsOnOrder {get;set;}
		public bool ProductAvailable {get;set;}
		public bool DiscountAvailable {get;set;}
		public bool CurrentOrder {get; set;}
	        public int ProductPicturesId { get; set; }
        	[NotMapped]
	        public ProductPictures Pictures {get;set;}
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
		public IList<ProductAttribute> ProductAttributes { get; set;}
		public void AddCategory(ProductCategory category)
	        {
        	    category.Product = this;
	            Categories.Add(category);
	        }

        public void AddMedia(ProductMedia media)
        {
            media.Product = this;
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
            ProductLinks.Add(productLink);
        }


    }
}
