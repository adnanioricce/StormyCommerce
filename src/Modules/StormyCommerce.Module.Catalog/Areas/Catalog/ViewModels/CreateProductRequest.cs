using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;

namespace StormyCommerce.Module.Catalog.Areas.Catalog.ViewModels
{
    public class CreateProductRequest
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string SKU { get; set; }       
        [Required]
        public Brand Brand { get; set; }
        [Required]
        public List<ProductCategory> Categories { get; set; } = new List<ProductCategory>();
        [Required]
        public StormyVendor Vendor { get; set; }
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
        public List<ProductMedia> Medias { get; set; } = new List<ProductMedia>();
        public List<ProductLinkDto> Links { get; set; } = new List<ProductLinkDto>();
        public string Note { get; set; }        
        public int Ranking { get; set; }
        public decimal ProductCost { get; set; }
    }
}
