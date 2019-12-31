using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace StormyCommerce.Core.Models.Requests
{
    public class EditProductRequest
    {
        public long Id { get; set; }
        [Required]
        public string SKU { get; set; }        
        [Required]
        public string ProductName { get; set; }
        public string Slug { get; set; }            
        [Required(AllowEmptyStrings = true)]
        public string ShortDescription { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        public int QuantityPerUnity { get; set; }
        [Required]
        public string AvailableSizes { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
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
        public int UnitsOnOrder { get; set; }
        [Required]
        public string ThumbnailImage { get; set; }                
        public string Note { get; set; }
        [Required]
        public string Price { get; set; }
        public decimal ProductCost { get; set; }                
    }
}
