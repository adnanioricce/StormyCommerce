using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Models.Requests
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
        public int VendorId { get; set; }
        [Required]
        [StringLength(450)]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }                
        [DataType(DataType.Currency)]
        [Required]
        public decimal UnitPrice { get; set; }
        [DataType(DataType.Currency)]
        public Price Price { get; set; }
        public decimal Discount { get; set; }
        [Required]
        public double UnitWeight { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Length { get; set; }
        public double? Diameter { get; set; }
        [Required]
        public int UnitsInStock { get; set; }                
        [Required]
        public string ThumbnailImage { get; set; }                
        public List<ProductMedia> Medias { get; set; } = new List<ProductMedia>();
        public List<ProductLink> Links { get; set; } = new List<ProductLink>();        
    }
}
