using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Module.Catalog.Models;
namespace StormyCommerce.Module.Catalog.Models.Requests
{
    public class CreateProductRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Sku { get; set; }       
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
        public int StockQuantity { get; set; }                
        [Required]
        public string ThumbnailImage { get; set; }                
        public List<ProductMedia> Medias { get; set; } = new List<ProductMedia>();
        public List<ProductLink> Links { get; set; } = new List<ProductLink>();        
    }
}
