using System;
using System.Collections.Generic;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Infraestructure.Data;
namespace TestHelperLibrary.Utils
{
    public class StormyDbContextInitializer 
    {
        // private readonly Dictionary<int, StormyProduct> Products = new Dictionary<int, StormyProduct>();
        public static void Initialize(StormyDbContext context)
        {
            var initializer = new StormyDbContextInitializer();
            initializer.SeedTestDb(context);
        }
        public void SeedTestDb(StormyDbContext context)
        {
            context.Database.EnsureCreated();            
            context.Set<StormyProduct>().AddRange(SeedProducts());
        }
        public List<StormyProduct> SeedProducts()
        {
            return new List<StormyProduct>
            {
                new StormyProduct
                {
                    SKU = Guid.NewGuid().ToString("N"),
                    AllowCustomerReview = true,
                    ApprovedRatingSum = 5,
                    ApprovedTotalReviews = 32,
                    AvailableForPreorder = false,
                    Brand = new Brand
                    {
                        Deleted = false,
                        Description = "description",                        
                        LastModified = new DateTime(2019,03,02),
                        LogoImage = "no Image",
                        Name = "A brand"
                    },
                    BrandId = 1,
                    CreatedAt = new DateTime(2019,05,10),
                    CurrentOrder = false,
                    Deleted = false,
                    Discount = (decimal)9.99,
                    DiscountAvailable = false,
                    HasDiscountApplied = false,
                    PreOrderAvailabilityStartDate = null,
                    ProductAvailable = true,
                    NotApprovedRatingSum = 2,
                    NotApprovedTotalReviews = 10,
                    VendorId = 1,
                    Vendor = new StormyVendor
                    {
                        Address = new Address
                        {
                            City = "NoWhere",
                            Complement = "A simple complement",
                            FirstAddress = "first Address",                            
                            LastModified = DateTime.UtcNow,
                            Number = Guid.NewGuid().ToString("N"),
                            PhoneNumber = "9999999-11",
                            PostalCode = "12345678-9",
                            SecondAddress = "Second Address",
                            State = "Hell",
                            Street = "Mcdonalds",
                            ParentId = 1
                        },
                        AddressId = 1,
                        CompanyName = "SimpleCompany",
                        ContactTitle = "Simple and a bit trustful",
                        TypeGoods = "Fashion",
                        WebSite = "www.simplecompanyonweb.com",
                        Email = "simplecompany@simpl.com",                        
                        LastModified = DateTime.UtcNow,
                        Logo = "no image",
                        Phone = "8887445512-11",
                        SizeUrl = "www.sizes.com",
                        Note = "Sample Data"
                    },
                    UnitPrice = (decimal)49.99,
                    UnitsInStock = 30,
                },
                new StormyProduct{                    
                    Ranking = 7,
                    SKU = "33E386EE-40A9-4AAA-9FA4-E0A196DC10ED",
                    UnitsInStock = 4,
                    VendorId = 1,
                    Vendor = new StormyVendor{
                        
                    }                  

                },
                new StormyProduct{                    
                    Ranking = 6,
                    ProductAvailable = true,
                    UnitsInStock = 10,
                    VendorId = 1,
                    Vendor = new StormyVendor{

                    }
                },
                new StormyProduct{                    
                    Ranking = 5,
                    ProductAvailable = true,
                    UnitsInStock = 2,
                    VendorId = 4,
                    Vendor = new StormyVendor{

                    }
                },
                new StormyProduct{                    
                    Ranking = 4,
                    ProductAvailable = true,
                    UnitsInStock = 4,
                    VendorId = 5,
                    Vendor = new StormyVendor{

                    }
                },
                new StormyProduct{                    
                    Ranking = 3,
                    ProductAvailable = true,
                    UnitsInStock = 8,
                    VendorId = 6,
                    Vendor = new StormyVendor{

                    }
                }
            };
        }
    }
}
