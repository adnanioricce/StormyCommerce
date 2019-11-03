using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Module.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class ProductDto
    {
        public ProductDto(){}

        public ProductDto(StormyProduct product, long id)
        {
            Id = id;
            ProductName = product.ProductName;
            Slug = product.Slug;
            QuantityPerUnity = product.QuantityPerUnity;
            AvailableSizes = AvailableSizes;
            Height = product.Height;
            Width = product.Width;
            Length = product.Length;
            Discount = product.Discount;
            UnitWeight = product.UnitWeight;
            UnitsInStock = product.UnitsInStock;
            UnitsOnOrder = product.UnitsOnOrder;
            Price = product.Price.Value;
            OldPrice = product.OldPrice.Value;            
        }

        public ProductDto(StormyProduct product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            Slug = product.Slug;
            QuantityPerUnity = product.QuantityPerUnity;
            AvailableSizes = product.AvailableSizes;
            Height = product.Height;
            Width = product.Width;
            Length = product.Length;
            Discount = product.Discount;
            UnitWeight = product.UnitWeight;
            UnitsInStock = product.UnitsInStock;
            UnitsOnOrder = product.UnitsOnOrder;
            Price = product.Price.Value;
            OldPrice = product.OldPrice.Value;
            ThumbnailImage = product.ThumbnailImage;
            Medias = product.Medias.Select(p => new ProductMediaDto(p)).ToList();
            Brand = new BrandDto(product.Brand);                        
            Vendor = new VendorDto(product.Vendor);
        }

        public long Id { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public bool ProductAvailable { get; set; }
        public string Slug { get; set; }
        public int QuantityPerUnity { get; set; }
        public string AvailableSizes { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public double UnitWeight { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public string Price { get; set; }
        public string OldPrice { get; set; }
        public string ThumbnailImage { get; set; }
        public List<ProductCategory> Categories { get; set; } = new List<ProductCategory>();
        public BrandDto Brand { get; set; }
        public VendorDto Vendor { get; set; }
        public List<ProductMediaDto> Medias { get; set; }

        public StormyProduct ToStormyProduct()
        {
            return new StormyProduct
            {
                ProductName = this.ProductName,
                Slug = this.Slug,
                QuantityPerUnity = this.QuantityPerUnity,
                AvailableSizes = this.AvailableSizes,
                UnitPrice = this.UnitPrice,
                Discount = this.Discount,
                UnitWeight = this.UnitWeight,
                UnitsInStock = this.UnitsInStock,
                UnitsOnOrder = this.UnitsOnOrder,
                Price = Core.Models.Price.GetPriceFromString(this.Price),
                OldPrice = Core.Models.Price.GetPriceFromString(this.OldPrice)                
            };
        }
    }
}
