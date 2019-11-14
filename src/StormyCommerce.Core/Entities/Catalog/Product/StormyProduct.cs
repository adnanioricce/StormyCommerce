using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class StormyProduct : BaseEntity
    {
        public StormyProduct(long id){
            Id = id;
        }     
        public StormyProduct(ProductDto productDto)
        {
            Id = productDto.Id;
            Slug = productDto.Slug;
            ProductName = productDto.ProductName;            
            Price = productDto.Price;
            QuantityPerUnity = productDto.QuantityPerUnity;
            UnitPrice = productDto.UnitPrice;
            UnitsInStock = productDto.UnitsInStock;
            AvailableSizes = productDto.AvailableSizes;
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
        public string ProductName { get; set; }
        public string Slug { get; set; }        
        public long BrandId { get; set; }        
        public long VendorId { get; set; }
        public long CategoryId { get; set; }
        public long? MediaId { get; set; }
        public long? ProductLinksId { get; set; }                
        public StormyVendor Vendor { get; set; }
        public Brand Brand { get; set; }        
        public string ShortDescription { get; set; }
        public string Description { get; set; }        
        public int QuantityPerUnity { get; set; }
        public string AvailableSizes { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public double UnitWeight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double? Diameter { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }                
        public string ThumbnailImage { get; set; }
        public List<ProductMedia> Medias { get; set; } = new List<ProductMedia>();
        public List<ProductLink> Links { get; set; } = new List<ProductLink>();           
        public List<ProductAttributeValue> AttributeValues { get; set; } = new List<ProductAttributeValue>();
        public List<ProductOptionValue> OptionValues { get; set; } = new List<ProductOptionValue>();        
        public List<ProductCategory> Categories { get; set; } = new List<ProductCategory>();
        public string Note { get; set; }        
        public string Price { get; set; }                                                                                                      
        public decimal ProductCost { get; set; }        
        public DateTime? PublishedOn { get; set;}
        public DateTime? CreatedOn { get; set; }            
        public int RatingAverage { get; set; }        
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
            Links.Add(productLink);
        }
        public string GenerateSlug()
        {
            return this.ProductName.Replace(' ','-');
        }
        public ProductDto ToProductDto()
        {
            return new ProductDto(this);
        }
        
        public double CalculateDimensions()
        {                      
            return Height * Width * Length;
        }        
    }
}
