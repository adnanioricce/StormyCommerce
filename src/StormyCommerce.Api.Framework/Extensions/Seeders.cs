using Bogus;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Entities.Order;

namespace StormyCommerce.Api.Framework.Extensions
{
    public static class Seeders
    {
        public static List<StormyProduct> StormyProductSeed(int count = 1,bool omitId = false)
        {            
            var fakeProduct = new Faker<StormyProduct>("pt_BR")
                .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
                .RuleFor(v => v.ProductName, f => f.Commerce.ProductName())
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.SKU, f => f.Commerce.Random.AlphaNumeric(16))
                .RuleFor(v => v.Slug, f => f.Lorem.Slug())
                .RuleFor(v => v.TypeName, f => f.Commerce.Categories(1)[0])
                .RuleFor(v => v.QuantityPerUnity, f => f.Commerce.Random.Even(0, 100))
                .RuleFor(v => v.UnitSize, f => f.Commerce.Random.Decimal(0, 10.0m))
                .RuleFor(v => v.UnitPrice, f => f.Commerce.Random.Decimal(0, 100.0m))
                .RuleFor(v => v.UnitWeight, f => f.Random.Double())
                .RuleFor(v => v.UnitsInStock, f => f.Random.Int(0, 10))
                .RuleFor(v => v.UnitsOnOrder, f => f.Random.Int(0, 9))
                .RuleFor(v => v.ProductAvailable, true)
                .RuleFor(v => v.StockTrackingIsEnabled, true)
                .RuleFor(v => v.Ranking, f => f.IndexVariable)
                .RuleFor(v => v.Note, f => f.Lorem.Text())
                .RuleFor(v => v.Price, f => f.Commerce.Price(1, 100, 2, "R$"))
                .RuleFor(v => v.OldPrice, f => f.Commerce.Price(2, 200, 2, "R$"))
                .RuleFor(v => v.HasDiscountApplied, false)
                .RuleFor(v => v.Published, true)
                .RuleFor(v => v.Status, "Good")
                .RuleFor(v => v.NotReturnable, f => false)
                .RuleFor(v => v.ProductCost, f => f.Random.Decimal())
                .RuleFor(v => v.AvailableForPreorder, f => false)
                .RuleFor(v => v.CreatedAt, f => f.Date.Past())
                .RuleFor(v => v.UpdatedOnUtc, f => f.Date.Between(f.Date.Recent(), f.Date.Soon()))
                .RuleFor(v => v.PreOrderAvailabilityStartDate, f => f.Date.Future())
                .RuleFor(v => v.BrandId,f => f.IndexVariable)
                .RuleFor(v => v.CategoryId, f => f.IndexVariable)
                .RuleFor(v => v.VendorId, f => f.IndexVariable)
                .RuleFor(v => v.MediaId, f => f.IndexVariable);                
            var products = fakeProduct.Generate(count);
            return products;
        }
        public static List<Entity> EntitySeed(int count = 1,string entityType = "Product", bool omitId = false)
        {
            var fakeEntity = new Faker<Entity>("pt_BR")
            .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
            .RuleFor(v => v.IsDeleted,false)
            .RuleFor(v => v.LastModified,f => f.Date.Recent(2))
            .RuleFor(v => v.EntityTypeId,entityType)
            .RuleFor(v => v.EntityId,1)
            .RuleFor(v => v.Name,f => f.Commerce.ProductName())
            .RuleFor(v => v.Slug,f => f.Lorem.Slug());
            return fakeEntity.Generate(count);            
        }
        public static List<ProductAttributeGroup> ProductAttributeGroupSeed(int count = 1, bool omitId = false)
        {
            var fakeProductAttributeGroup = new Faker<ProductAttributeGroup>("pt_BR")               
               .RuleFor(v => v.IsDeleted, false)
               .RuleFor(v => v.LastModified, f => f.Date.Recent(14))
               .RuleFor(v => v.Name, f => f.Commerce.ProductAdjective());
            return fakeProductAttributeGroup.Generate(count);
        }
        public static List<ProductAttribute> ProductAttributeSeed(int count = 1, bool omitId = false)
        {            
            var productAttributeGroup = ProductAttributeGroupSeed();
            var fakeProductAttribute = new Faker<ProductAttribute>("pt_BR")
                .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.LastModified, f => f.Date.Recent(14))
                .RuleFor(v => v.Name, f => f.Commerce.ProductAdjective())
                .RuleFor(v => v.GroupId, f => f.PickRandom(productAttributeGroup).Id);
            return fakeProductAttribute.Generate(count);
        }
        public static List<ProductLink> ProductLinkSeed(int count = 1, bool omitId = false)
        {
            var products = StormyProductSeed(count);            
            var fakeProductLink = new Faker<ProductLink>("pt_BR")
               .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
               .RuleFor(v => v.LinkType, ProductLinkType.Related)
               .RuleFor(v => v.IsDeleted, false)
               .RuleFor(v => v.LastModified, f => f.Date.Recent(25))
               .RuleFor(v => v.LinkedProductId,f => f.Random.Int(1,count))
               .RuleFor(v => v.ProductId, f => f.Random.Int(1, count));           
            return fakeProductLink.Generate(count);
        }
        public static List<Media> MediaSeed(int count = 1, bool omitId = false)
        {            
            var fakeMedias = new Faker<Media>("pt_BR")                
                .RuleFor(v => v.Id,f => ++f.IndexVariable)
                .RuleFor(v => v.FileName, f => f.Image.LoremPixelUrl("fashion"))
                .RuleFor(v => v.FileSize, f => f.System.Random.Int())
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.LastModified, f => f.Date.Recent(14))
                .RuleFor(v => v.MediaType, MediaType.Image);
            return fakeMedias.Generate(count);
        }
        public static List<Brand> BrandSeed(int count = 1, bool omitId = false)
        {            
            var fakeBrands = new Faker<Brand>("pt_BR")
                .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.LastModified, f => f.Date.Recent(24))
                .RuleFor(v => v.LogoImage, f => f.Image.PicsumUrl())
                .RuleFor(v => v.Name, f => f.Company.CompanyName())
                .RuleFor(v => v.Slug, f => f.Lorem.Slug(3))
                .RuleFor(v => v.Website, f => f.Person.Website)
                .RuleFor(v => v.Description, f => f.Lorem.Text());

            return fakeBrands.Generate(count);
        }
        public static List<StormyVendor> StormyVendorSeed(int count = 1, bool omitId = false)
        {            
            var fakeVendors = new Faker<StormyVendor>("pt_BR")
                .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.LastModified, f => f.Date.Recent(27))
                .RuleFor(v => v.CompanyName, f => f.Company.CompanyName())
                .RuleFor(v => v.ContactTitle, f => f.Person.UserName)
                .RuleFor(v => v.Email, f => f.Person.Email)
                .RuleFor(v => v.Logo, f => f.Image.LoremFlickrUrl())
                .RuleFor(v => v.Note, f => f.Lorem.Text())
                .RuleFor(v => v.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(v => v.SizeUrl, f => $"{f.Internet.Random.Even()}")
                .RuleFor(v => v.TypeGoods, f => f.Commerce.Department())
                .RuleFor(v => v.WebSite, f => f.Person.Website);
            return fakeVendors.Generate(count);
        }
        public static List<Category> CategorySeed(int count = 1, bool omitId = false)
        {            
            var fakeCategory = new Faker<Category>("pt_BR")
                .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
                .RuleFor(v => v.LastModified, f => f.Date.Recent(24))
                .RuleFor(v => v.Description, f => f.Lorem.Text())
                .RuleFor(v => v.DisplayOrder, f => f.IndexFaker)
                .RuleFor(v => v.IncludeInMenu, true)
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.IsPublished, true)
                .RuleFor(v => v.MetaDescription, f => f.Lorem.Text())
                .RuleFor(v => v.Slug, f => f.Lorem.Slug())
                .RuleFor(v => v.Name, f => f.Commerce.Categories(1)[0])
                .RuleFor(v => v.ThumbnailImageUrl, f => f.Image.LoremPixelUrl("fashion"));
                // .RuleFor(v => v.ParentId,f => f.Random.Int(1,count));                            
            return fakeCategory.Generate(count);
        }        
        public static List<Address> AddressSeed(int count = 1, bool omitId = false)
        {
            var fakeAddress = new Faker<Address>("pt_BR")       
                .RuleFor(v => v.Id,f => omitId ? 0 : ++f.IndexVariable)         
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.FirstAddress, f => f.Address.StreetName())
                .RuleFor(v => v.SecondAddress, f => f.Address.SecondaryAddress())
                .RuleFor(v => v.PostalCode, f => f.Address.ZipCode())
                .RuleFor(v => v.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(v => v.Street, f => f.Address.StreetAddress())
                .RuleFor(v => v.State, f => f.Address.State())
                .RuleFor(v => v.Number, f => f.Address.BuildingNumber())
                .RuleFor(v => v.City, f => f.Address.City());                
            return fakeAddress.Generate(count);
        }
            
        public static List<StormyOrder> StormyOrderSeed(int count = 1)
        {
            var fakeOrder = new Faker<StormyOrder>("pt_BR")                
                .RuleFor(v => v.Comment, f => f.Lorem.Sentence())
                .RuleFor(v => v.DeliveryCost, f => f.Finance.Amount(0, 100))
                .RuleFor(v => v.DeliveryDate, f => f.Date.Soon(14))
                .RuleFor(v => v.Discount, f => f.Finance.Amount(1, 100))
                .RuleFor(v => v.IsCancelled, false)
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.LastModified, f => f.Date.Recent(14))
                .RuleFor(v => v.Note, f => f.Lorem.Text())
                .RuleFor(v => v.OrderDate, f => f.Date.Recent(4))
                .RuleFor(v => v.PaymentDate, f => f.Date.Recent(2))
                .RuleFor(v => v.PaymentMethod, f => f.Finance.TransactionType())
                .RuleFor(v => v.PickUpInStore, f => f.Random.Bool())
                .RuleFor(v => v.RequiredDate, f => f.Date.Soon(7))
                .RuleFor(v => v.ShippedDate, f => f.Date.Soon(7))
                .RuleFor(v => v.ShippingMethod, "Default")
                .RuleFor(v => v.ShippingStatus, f => f.PickRandomWithout<ShippingStatus>())
                .RuleFor(v => v.Status, f => f.PickRandomWithout<OrderStatus>())
                .RuleFor(v => v.Tax, f => f.Finance.Amount(0, 50))
                .RuleFor(v => v.TotalPrice, f => f.Finance.Amount(0, 100))
                .RuleFor(v => v.TotalWeight, f => f.Commerce.Random.Decimal(1, 500))
                .RuleFor(v => v.TrackNumber, f => f.Address.Random.AlphaNumeric(24))
                .RuleFor(v => v.OrderUniqueKey, f => f.Commerce.Random.Guid());

            return fakeOrder.Generate(count);
        }        
        public static List<ProductTemplateProductAttribute> ProductTemplateProductAttribute(int count = 1)
        {
            var fakeProductTemplateProductAttribute = new Faker<ProductTemplateProductAttribute>("pt_BR")
                .RuleFor(v => v.ProductAttributeId, f => f.IndexVariable++)
                .RuleFor(v => v.ProductTemplateId, f => f.IndexVariable++);
            return fakeProductTemplateProductAttribute.Generate(count);
        }
        public static List<ProductTemplate> ProductTemplateSeed(int count = 1)
        {
            var fakeProductTemplate = new Faker<ProductTemplate>("pt_BR")
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.LastModified, f => f.Date.Recent(14))
                .RuleFor(v => v.Name, f => f.Commerce.Product())
                .RuleFor(v => v.ProductAttributes, ProductTemplateProductAttribute(count));
            return fakeProductTemplate.Generate(count);
        }
    }
}
