using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Module.Catalog.Areas.Catalog.ViewModels
{
    public class CreateProductRequest
    {
        [Required]
        public string ProductName { get; set; }
        public string SKU { get; set; }       
        [Required]
        public BrandDto Brand { get; set; }
        [Required]
        public CategoryDto Category { get; set; } 
        [Required]
        public VendorDto Vendor { get; set; }
        [Required]
        [StringLength(450)]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }        
        [Required]
        public int QuantityPerUnity { get; set; }
        [Required]
        public string AvailableSizes { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        [Required]
        public double UnitWeight { get; set; }
        [Required]
        public decimal Height { get; set; }
        [Required]
        public decimal Width { get; set; }
        [Required]
        public decimal Length { get; set; }
        public int? Diameter { get; set; }
        [Required]
        public int UnitsInStock { get; set; }        
        public bool ProductAvailable { get; set; }
        [Required]
        public string ThumbnailImage { get; set; }                
        public List<ProductMediaDto> Medias { get; set; }
        public List<ProductDto> Links { get; set; }
        public string Note { get; set; }        
        public int Ranking { get; set; }
        public decimal ProductCost { get; set; }
    }
}