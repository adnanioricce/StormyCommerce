using System.Collections.Generic;
using System.Linq;
using SimplCommerce.Module.Catalog.Models;

namespace SimplCommerce.Module.Catalog.Models.Dtos
{
    public class ProductDto
    {
        public ProductDto(){}

        public ProductDto(Product product, long id)
        {
            Id = id;
            ProductName = product.ProductName;
            Slug = product.Slug;            
            AvailableSizes = AvailableSizes;
            Height = product.Height;
            Width = product.Width;
            Length = product.Length;
            Discount = product.Discount;
            UnitWeight = product.UnitWeight;
            UnitsInStock = product.UnitsInStock;
            UnitsOnOrder = product.UnitsOnOrder;
            Price = product.Price;                  
        }

        public ProductDto(Product product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            Slug = product.Slug;            
            ShortDescription = product.ShortDescription;
            Description = product.Description;
            Height = product.Height;
            Width = product.Width;
            Length = product.Length;
            Discount = product.Discount;
            UnitWeight = product.UnitWeight;
            UnitsInStock = product.UnitsInStock;
            UnitsOnOrder = product.UnitsOnOrder;
            UnitPrice = product.Price;            
            Price = product.Price;            
            ThumbnailImage = product.ThumbnailImage.FileName;
            Medias = product.Medias.Select(m => new ProductMediaDto(m)).ToList();
            Categories = product.Categories.Select(c => new ProductCategoryDto(c)).ToList();
            Brand = product.Brand == null ? this.Brand : new BrandDto(product.Brand);                                   
        }

        public long Id { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool ProductAvailable { get; set; }
        public string Slug { get; set; }
        public int QuantityPerUnity { get; set; }
        public string AvailableSizes { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double UnitWeight { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public string ThumbnailImage { get; set; }
        public List<ProductCategoryDto> Categories { get; set; } = new List<ProductCategoryDto>();
        public BrandDto Brand { get; set; }        
        public List<ProductMediaDto> Medias { get; set; }

        public Product ToStormyProduct()
        {
            return new Product
            {
                ProductName = this.ProductName,
                Slug = this.Slug,                
                Discount = this.Discount,
                UnitWeight = this.UnitWeight,
                UnitsInStock = this.UnitsInStock,
                UnitsOnOrder = this.UnitsOnOrder,
                Price = this.Price,                        
            };
        }
    }
}
