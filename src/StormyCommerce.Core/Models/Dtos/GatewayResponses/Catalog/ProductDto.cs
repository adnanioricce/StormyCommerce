using StormyCommerce.Core.Entities.Catalog.Product;
using System.Collections.Generic;
namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{	
	public class ProductDto
	{
        public ProductDto(StormyProduct product)
        {
            
        }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public int QuantityPerUnity { get; set; }
        public string UnitSize { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public double UnitWeight { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public decimal Price { get; set; }
        //TODO:
        //public StormyVendor Vendor { get; set; }
        //public Brand Brand { get; set; }
        //public Category Category { get; set; }
    }
}
