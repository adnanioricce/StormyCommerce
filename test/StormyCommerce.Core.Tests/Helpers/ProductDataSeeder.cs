using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Vendor;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class ProductDataSeeder
    {
        public static StormyProduct GetSampleData()
        {
            return new StormyProduct(54)
            {
                SKU = "33E353EE-40A9-4AAA-9FA4-E0A196DC10ED",
                AllowCustomerReview = true,
                ApprovedRatingSum = 5,
                ApprovedTotalReviews = 32,
                AvailableForPreorder = false,
                BrandId = 1,
                CreatedOn = new DateTime(2019, 05, 10),
                IsDeleted = false,
                Discount = (decimal)9.99,
                DiscountAvailable = false,
                HasDiscountApplied = false,
                PreOrderAvailabilityStartDate = null,
                ProductAvailable = true,
                NotApprovedRatingSum = 2,
                NotApprovedTotalReviews = 10,
                VendorId = 1,
                UnitPrice = (decimal)49.99,
                UnitsInStock = 30,
                Category = new Entities.Catalog.Category{
                    Name = "Shirts"
                },                
                Brand = new Brand{
                    Name = "Nike"
                },
                ProductName = "Nike Shirt Zeus"
            };
        }

        public static List<StormyProduct> GetListData()
        {
            return new List<StormyProduct>
            {
                new StormyProduct(51)
                {
                    ProductName = "camiseta com nome legal",
                    SKU = Guid.NewGuid().ToString("N"),
                    AllowCustomerReview = true,
                    ApprovedRatingSum = 5,
                    ApprovedTotalReviews = 32,
                    AvailableForPreorder = false,
                    Brand = new Brand
                    {
                        IsDeleted = false,
                        Description = "description",
                        LastModified = new DateTime(2019,03,02),
                        LogoImage = "no Image",
                        Name = "A brand"
                    },
                    BrandId = 1,
                    CreatedOn = new DateTime(2019,05,10),
                    IsDeleted = false,
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
                        Address = new VendorAddress{
                            Address = new Address("BR","Hell","NoWhere","Disney","Mcdonalds","First address","Second address","12345678-9","4002","A simple complement")
                        }
                        ,
                        VendorAddressId = 1,
                        CompanyName = "SimpleCompany",
                        ContactTitle = "Simple and a bit trustful",
                        TypeGoods = "Fashion",
                        WebSite = "www.simplecompanyonweb.com",
                        Email = "simplecompany@simpl.com",
                        LastModified = DateTime.UtcNow,
                        Logo = "no image",
                        Phone = "8887445512-11",
                        SizeUrl = "www.sizes.com",
                        Note = "Sample Data",
                    },
                    UnitPrice = (decimal)49.99,
                    UnitsInStock = 30,
                },
                new StormyProduct{
                    Ranking = 7,
                    SKU = "33E386EE-40A9-4AAA-9FA4-E0A196DC10ED",
                    UnitsInStock = 4,
                    VendorId = 1,
                    IsDeleted = false,
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
