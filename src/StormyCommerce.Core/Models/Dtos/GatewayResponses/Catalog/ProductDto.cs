using StormyCommerce.Core.Entities.Catalog.Product;
using System.Collections.Generic;
namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{	
	public class ProductDto
	{
        public ProductDto()
        {
            
        }
        public ProductDto(StormyProduct product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            Slug = product.Slug;
            QuantityPerUnity = product.QuantityPerUnity;
            UnitSize = product.UnitSize;
            Discount = product.Discount;
            UnitWeight = product.UnitWeight;
            UnitsInStock = product.UnitsInStock;
            UnitsOnOrder = product.UnitsOnOrder;
            Price = product.Price;
            OldPrice = product.OldPrice;
            Brand = new BrandDto(product.Brand);
            Category = new CategoryDto(product.Category);
            //Vendor = new VendorDto(product.Vendor);
        }
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public int QuantityPerUnity { get; set; }
        public string UnitSize { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public double UnitWeight { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public string Price { get; set; }
        public string OldPrice { get; set; }        
        public CategoryDto Category { get; set; }
        public BrandDto Brand { get; set; }
        //public VendorDto Vendor { get; set; }
        //TODO:
        //public StormyVendor Vendor { get; set; }
        //public Brand Brand { get; set; }
        //public Category Category { get; set; }
        public StormyProduct ToStormyProduct()
        {
            return new StormyProduct
            {
                ProductName = this.ProductName,
                Slug = this.Slug,
                QuantityPerUnity = this.QuantityPerUnity,
                UnitSize = this.UnitSize,
                UnitPrice = this.UnitPrice,
                Discount = this.Discount,
                UnitWeight = this.UnitWeight,
                UnitsInStock = this.UnitsInStock,
                UnitsOnOrder = this.UnitsOnOrder,
                Price = this.Price
            };
        }
    }
}
