//using Bogus;
//using Bogus.DataSets;
//using StormyCommerce.Core.Entities;
//using StormyCommerce.Core.Entities.Common;
//using StormyCommerce.Core.Entities.Customer;
//using StormyCommerce.Core.Entities.Media;
//
//using StormyCommerce.Core.Entities.Shipping;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace StormyCommerce.Api.Framework.Extensions
//{
//    public static class Seeders
//    {
//        public static List<StormyProduct> StormyProductSeed(int count = 1)
//        {
//            var fakeProduct = new Faker<StormyProduct>("pt_BR")
//                .Rules((Action<Faker, StormyProduct>)((f, v) =>
//                {
//                    v.Id = 0;
//                    v.ProductName = f.Commerce.ProductName();
//                    v.IsDeleted = false;
//                    v.ThumbnailImage = f.Image.LoremPixelUrl(category: LoremPixelCategory.Fashion);
//                    v.Sku = f.Commerce.Random.AlphaNumeric(16);
//                    v.Slug = f.Lorem.Slug();
//                    v.QuantityPerUnity = f.Commerce.Random.Even(0, 100);
//                    v.AvailableSizes = "GG,G,M,P,PP";
//                    v.UnitPrice = f.Commerce.Random.Decimal(0, 100.0m);
//                    v.UnitWeight = f.Random.Double();
//                    v.UnitsInStock = f.Random.Int(2, 10);
//                    v.UnitsOnOrder = f.Random.Int(0, 2);
//                    v.Note = f.Lorem.Sentence();
//                    v.Price = f.Commerce.Price(1, 100, 2, "R$");
//                    v.ProductCost = f.Random.Decimal();
//                    v.CreatedOn = f.Date.Past();
//                    v.Brand = Seeders.BrandSeed(omitId: true).First();
//                    var vendor = Seeders.StormyVendorSeed().First();

//                    vendor.Addresses.Add(new VendorAddress
//                    {
//                        Address = new Core.Entities.Common.AddressDetail("br", "sp", "Varginha", "distrito 9", "rua do conhecimento", "", "", "40028922", "666", "busque conhecimento", "", "")
//                    });
//                    v.Vendor = vendor;
//                    Seeders.MediaSeed(1)
//                        .ForEach(m => v.AddMedia(m));
//                    v.ThumbnailImage = f.Image.LoremPixelUrl(LoremPixelCategory.Fashion);
//                    var category = ProductCategorySeed(omitId: true).First();
//                    v.Categories.Add(category);
//                    v.Width = f.Random.Double(1.0, 20.0);
//                    v.Height = f.Random.Double(1.0, 20.0);
//                    v.Length = f.Random.Double(1.0, 20.0);
//                }));
//            return fakeProduct.Generate(count);
//        }
//        public static List<StormyShipment> ShipmentSeed(int count = 1,bool omitId = false)
//        {
//            var fakeShipment = new Faker<StormyShipment>("pt_BR")
//                .Rules((f, v) =>
//                {
//                    v.DestinationAddress = new CustomerAddress
//                    {
//                        Details = new AddressDetail(f.Address.CountryCode(),f.Address.State(),f.Address.City(),f.Address.CitySuffix(),f.Address.StreetName(),f.Address.StreetAddress(),f.Address.SecondaryAddress(),f.Address.ZipCode(),f.Address.BuildingNumber(),f.Address.CityPrefix(),f.Person.FirstName,f.Phone.PhoneNumber()),                        
//                        WhoReceives = "I",
//                        Type = AddressType.Shipping,
//                        IsDefault = true,
//                    };
//                })
//                .RuleFor(v => v.DeliveryCost, f => f.Random.Decimal(8.90m, 42.90m))
//                .RuleFor(v => v.ShipmentMethod, f => f.PickRandom<ShippingMethod>())
//                .RuleFor(v => v.ShipmentProvider, "Correios")
//                .RuleFor(v => v.ShippedDate, f => f.Date.Recent())
//                .RuleFor(v => v.TotalWeight, f => f.Random.Double(5.0, 20.0))
//                .RuleFor(v => v.DeliveryDate, f => f.Date.Recent(4))
//                .RuleFor(v => v.DeliveryCost, f => f.Random.Decimal(3.0m, 62.0m))
//                .RuleFor(v => v.CreatedOn, f => f.Date.Recent(4));                                                                          
//            return fakeShipment.Generate(count);
//        }
//        public static List<Entity> EntitySeed(int count = 1, string entityType = "Product", bool omitId = false)
//        {
//            var fakeEntity = new Faker<Entity>("pt_BR")
//            .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
//            .RuleFor(v => v.IsDeleted, false)
//            .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(2))
//            .RuleFor(v => v.EntityTypeId, entityType)            
//            .RuleFor(v => v.Name, f => f.Commerce.ProductName())
//            .RuleFor(v => v.Slug, f => f.Lorem.Slug());
//            return fakeEntity.Generate(count);
//        }

//        //public static List<ProductAttributeGroup> ProductAttributeGroupSeed(int count = 1)
//        //{
//        //    var fakeProductAttributeGroup = new Faker<ProductAttributeGroup>("pt_BR")
//        //       .RuleFor(v => v.IsDeleted, false)
//        //       .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(14))
//        //       .RuleFor(v => v.Name, f => f.Commerce.ProductAdjective());
//        //    return fakeProductAttributeGroup.Generate(count);
//        //}

//        //public static List<ProductAttribute> ProductAttributeSeed(int count = 1, bool omitId = false)
//        //{
//        //    var productAttributeGroup = ProductAttributeGroupSeed();
//        //    var fakeProductAttribute = new Faker<ProductAttribute>("pt_BR")
//        //        .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
//        //        .RuleFor(v => v.IsDeleted, false)
//        //        .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(14))
//        //        .RuleFor(v => v.Name, f => f.Commerce.ProductAdjective())
//        //        .RuleFor(v => v.GroupId, f => f.PickRandom(productAttributeGroup).Id);
//        //    return fakeProductAttribute.Generate(count);
//        //}

//        //public static List<ProductLink> ProductLinkSeed(int count = 1, bool omitId = false)
//        //{
//        //    var products = StormyProductSeed(count);
//        //    var fakeProductLink = new Faker<ProductLink>("pt_BR")
//        //       .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
//        //       .RuleFor(v => v.LinkType, ProductLinkType.Related)
//        //       .RuleFor(v => v.IsDeleted, false)
//        //       .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(25))
//        //       .RuleFor(v => v.LinkedProductId, f => f.Random.Int(1, count))
//        //       .RuleFor(v => v.ProductId, f => f.Random.Int(1, count));
//        //    return fakeProductLink.Generate(count);
//        //}

//        //public static List<ProductMedia> MediaSeed(int count = 1)
//        //{            
//        //    var fakeMedias = new Faker<ProductMedia>("pt_BR")
//        //        .Rules((f,v) => {        
//        //            v.Id = f.IndexFaker;            
//        //            var media = new Media{
//        //                FileName = f.Image.LoremFlickrUrl(),
//        //                FileSize = f.System.Random.Int(24,1024),
//        //                MediaType = MediaType.Image
//        //            };
//        //            v.Media = media;                                        
//        //        });
//        //    return fakeMedias.Generate(count);
//        //}

//        //public static List<Brand> BrandSeed(int count = 1, bool omitId = false)
//        //{
//        //    var fakeBrands = new Faker<Brand>("pt_BR")
//        //        .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
//        //        .RuleFor(v => v.IsDeleted, false)
//        //        .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(24))
//        //        .RuleFor(v => v.LogoImage, f => f.Image.PicsumUrl())
//        //        .RuleFor(v => v.Name, f => f.Company.CompanyName())
//        //        .RuleFor(v => v.Slug, f => f.Lorem.Slug(3))
//        //        .RuleFor(v => v.Website, f => f.Person.Website)
//        //        .RuleFor(v => v.Description, f => f.Lorem.Text());

//        //    return fakeBrands.Generate(count);
//        //}

//        //public static List<StormyVendor> StormyVendorSeed(int count = 1)
//        //{
//        //    var fakeVendors = new Faker<StormyVendor>("pt_BR")                
//        //        .RuleFor(v => v.IsDeleted, false)
//        //        .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(27))
//        //        .RuleFor(v => v.CompanyName, f => f.Company.CompanyName())
//        //        .RuleFor(v => v.ContactTitle, f => f.Person.UserName)
//        //        .RuleFor(v => v.Email, f => f.Person.Email)
//        //        .RuleFor(v => v.Logo, f => f.Image.LoremFlickrUrl())
//        //        .RuleFor(v => v.Note, f => f.Lorem.Text())
//        //        .RuleFor(v => v.Phone, f => f.Phone.PhoneNumber())
//        //        .RuleFor(v => v.SizeUrl, f => $"{f.Internet.Random.Even()}")
//        //        .RuleFor(v => v.TypeGoods, f => f.Commerce.Department())
//        //        .RuleFor(v => v.WebSite, f => f.Person.Website)
//        //        .RuleFor(v => v.Slug,f => f.Company.CompanyName().Replace(" ","-"));
//        //    return fakeVendors.Generate(count);
//        //}

//        //public static List<Category> CategorySeed(int count = 1, bool omitId = false)
//        //{
//        //    var fakeCategory = new Faker<Category>("pt_BR")                
//        //        .RuleFor(v => v.Id, f => omitId ? 0 : ++f.IndexVariable)
//        //        .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(24))
//        //        .RuleFor(v => v.Description, f => f.Lorem.Text())
//        //        .RuleFor(v => v.DisplayOrder, f => f.IndexFaker)
//        //        .RuleFor(v => v.IncludeInMenu, true)
//        //        .RuleFor(v => v.IsDeleted, false)
//        //        .RuleFor(v => v.IsPublished, true)                
//        //        .RuleFor(v => v.Slug, f => f.Lorem.Slug())
//        //        .RuleFor(v => v.Name, f => f.Commerce.Categories(1)[0])
//        //        .RuleFor(v => v.ThumbnailImage, f => new Media {
//        //            FileName = f.Image.LoremPixelUrl("fashion")
//        //            });                
//        //    return fakeCategory.Generate(count);
//        //}
//        //public static List<ProductCategory> ProductCategorySeed(int count = 1, bool omitId = false)
//        //{
//        //    var fakeCategory = new Faker<ProductCategory>("pt_BR")                
//        //        .Rules((f,v) => 
//        //        {
//        //            v.Category = Seeders.CategorySeed(omitId:true).First();
//        //            v.DisplayOrder = f.Random.Int(1,104);                    
//        //        });
//        //    return fakeCategory.Generate(count);
//        //}

//        public static List<CustomerAddress> AddressSeed(int count = 1, bool omitId = false)
//        {
//            var fakeAddress = new Faker<CustomerAddress>("pt_BR")
//                .RuleFor(v => v.Id, f => omitId ? 0 : f.IndexVariable)
//                .RuleFor(v => v.IsDeleted, false)
//                .RuleFor(v => v.Details, f => new AddressDetail(
//                    f.Address.CountryCode(),
//                    f.Address.State(),
//                    f.Address.City(),
//                    f.Address.County(),
//                    f.Address.StreetName(),
//                    f.Address.StreetAddress(),
//                    f.Address.SecondaryAddress(),
//                    f.Address.ZipCode(),
//                    f.Address.BuildingNumber(),
//                    f.Lorem.Sentence(),"",""));                                      
//            return fakeAddress.Generate(count);
//        }

//        public static List<Order> OrderSeed(int count = 1)
//        {
//            var fakeOrder = new Faker<Order>("pt_BR")
//                .Rules((f,v) => {
//                    v.Comment = f.Lorem.Sentence();
//                    v.Discount = f.Finance.Amount(1, 100);
//                    v.IsCancelled = false;                    
//                    v.LatestUpdatedOn = f.Date.Recent(14);
//                    v.Note = f.Lorem.Text();
//                    v.OrderDate = f.Date.Recent(4);
//                    v.PaymentDate = f.Date.Recent(2);                    
//                    v.PickUpInStore = f.Random.Bool();
//                    v.RequiredDate = f.Date.Soon(7);                                                
//                    v.Status = f.PickRandom(new []{OrderStatus.New
//                        ,OrderStatus.OnHold
//                        ,OrderStatus.Complete
//                        ,OrderStatus.PendingPayment
//                        ,OrderStatus.PaymentReceived
//                        ,OrderStatus.Shipped
//                        ,OrderStatus.Shipping
//                        });                    
//                    v.TotalPrice = f.Finance.Amount(0, 100);                             
//                    v.OrderUniqueKey = f.Commerce.Random.Guid();
//                    var shipment = Seeders.ShipmentSeed(omitId:true).First();
//                    var customer = Seeders.StormyCustomerSeed(omitId:true).First();
//                    shipment.Order = v;                              
//                    v.Shipment = shipment;                    
//                    var items = Seeders.OrderItemSeed(2);                    
//                    var product = Seeders.StormyProductSeed().First();                    
//                    int i = 0;
//                    items.ForEach(item => {
//                        item.Id = 0;
//                        item.Product = product;
//                        item.Order = v;
//                        item.Shipment = shipment;
//                        v.AddItem(item);
//                    });                       
//                    var payment = Seeders.PaymentSeed();                    
//                    payment.Amount = v.TotalPrice;
//                    payment.Id = 0;
//                    v.Payment = payment;                                                                                              
//                });                
//            return fakeOrder.Generate(count);
//        }
//        //public static StormyPayment PaymentSeed()
//        //{
//        //    var fakePayment = new Faker<StormyPayment>("pt_BR")
//        //        .RuleFor(v => v.PaymentFee,f => f.Finance.Amount())
//        //        .RuleFor(v => v.PaymentMethod,f => f.PickRandom<PaymentMethod>())
//        //        .RuleFor(v => v.PaymentStatus,f => f.PickRandom(new [] {PaymentStatus.Authorized,PaymentStatus.Successful}))
//        //        .RuleFor(v => v.GatewayTransactionId,f => f.Finance.RoutingNumber())
//        //        .RuleFor(v => v.CreatedOn, DateTime.UtcNow);
//        //    return fakePayment.Generate(1).First();
//        //}
//        public static List<OrderItem> OrderItemSeed(int count = 1)
//        {
//            var fakeOrderItem = new Faker<OrderItem>("pt_BR")
//                .RuleFor(v => v.Price, f => f.Random.Decimal(1.0m, 100.0m))
//                .RuleFor(v => v.Quantity, f => f.Random.Int(1, 5));
//            return fakeOrderItem.Generate(count);
//        }
//        //public static List<ProductTemplateProductAttribute> ProductTemplateProductAttribute(int count = 1)
//        //{
//        //    var fakeProductTemplateProductAttribute = new Faker<ProductTemplateProductAttribute>("pt_BR")
//        //        .RuleFor(v => v.ProductAttributeId, f => f.IndexVariable++)
//        //        .RuleFor(v => v.ProductTemplateId, f => f.IndexVariable++);
//        //    return fakeProductTemplateProductAttribute.Generate(count);
//        //}

//        //public static List<ProductTemplate> ProductTemplateSeed(int count = 1)
//        //{
//        //    var fakeProductTemplate = new Faker<ProductTemplate>("pt_BR")
//        //        .RuleFor(v => v.IsDeleted, false)
//        //        .RuleFor(v => v.LatestUpdatedOn, f => f.Date.Recent(14))
//        //        .RuleFor(v => v.Name, f => f.Commerce.Product())
//        //        .RuleFor(v => v.ProductAttributes, ProductTemplateProductAttribute(count));
//        //    return fakeProductTemplate.Generate(count);
//        //}        

//        public static List<User> StormyCustomerSeed(int count = 1,bool omitId = false)
//        {
//            var fakeCustomer = new Faker<User>()
//                .Rules((f,v) => {
//                    v.Email = f.Internet.Email();
//                    v.EmailConfirmed = true;
//                    v.PhoneNumber = f.Person.Phone;
//                    v.PhoneNumberConfirmed =  true;                    
//                    v.UserName = f.Internet.UserName();
//                    v.CPF =  "000000000";
//                    v.CreatedOn =  DateTime.UtcNow;
//                    var addresses = Seeders.AddressSeed(2);
//                    addresses.ForEach(a => v.Addresses.Add(a));                                        
                                 
//                });                
            
//            return fakeCustomer.Generate(count);
//        }

//        //public static List<Review> ReviewSeed(int count = 1, bool ignoreId = false)
//        //{
//        //    var fakeReview = new Faker<Review>("pt_BR")
//        //        .RuleFor(v => v.Id, f => ignoreId ? 0 : ++f.IndexVariable)                
//        //        .RuleFor(v => v.Title, f => f.Lorem.Sentence())
//        //        .RuleFor(v => v.Comment, f => f.Rant.Review())
//        //        .RuleFor(v => v.ReviewerName, f => f.Person.FullName)
//        //        .RuleFor(v => v.RatingLevel, f => f.Random.Int(0, 5))
//        //        .RuleFor(v => v.Status, ReviewStatus.Approved);
//        //    return fakeReview.Generate(count);
//        //}        
//    }
//}
