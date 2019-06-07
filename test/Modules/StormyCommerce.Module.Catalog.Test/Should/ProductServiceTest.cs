using System;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using Xunit;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Product;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using StormyCommerce.Core.Services;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;

namespace StormyCommerce.Module.Catalog.Test.Should
{
    public class ProductServiceTest
    {        
        [Theory]
        [InlineData(1)]
        public async void GetProductByIdAsync(int id)
        {             
            var repo = new StormyRepository<StormyProduct>(FakeDbContext());
            await repo.AddAsync(GetSampleData());
            //Arrange 
            var service = new ProductService(repo);          
            //Act
            var entity =  await service.GetProductByIdAsync(id);
            Console.WriteLine($"Entity Id is :{entity.Id}");
            //Assert
            Assert.Equal(id,entity.Id);
        }
        [Theory]
        [InlineData("33E386EE-40A9-4AAA-9FA4-E0A196DC10ED")]
        public async void GetProductBySkuAsync(string sku)
        {
            //Arrange 
            var service = new ProductService(new StormyRepository<StormyProduct>(FakeDbContext()));    
            //Act
            var entity = await service.GetProductBySkuAsync(sku);
            //Assert
            Assert.Equal(sku,entity.SKU);
        }
        [Fact]
        public async void GetListProducts()
        {
            //Arrange 
            var repo = new StormyRepository<StormyProduct>(FakeDbContext());
            await repo.AddAsync(GetListData());
            var service = new ProductService(repo);   

            //Act
            var entities = await service.GetAllProductsDisplayedOnHomepageAsync(6);
            //Assert
            Assert.Equal(6,entities.Count);
        }

        [Theory]
        [InlineData(new int[] {7,5,4,1,3,9})]
        public async void GetProductsByIds(int[] ids)
        {            
            //Arrange 
            var service = new ProductService(new StormyRepository<StormyProduct>(FakeDbContext()));    
            //Act
            var entities = await service.GetProductsByIdsAsync(ids);
            //Assert
            Assert.Equal(1,entities.First(entity => entity.Id == 1).Id);
            Assert.Equal(7,entities.First(entity => entity.Id == 7).Id);
            Assert.Equal(4,entities.First(entity => entity.Id == 4).Id);
            Assert.Equal(3,entities.First(entity => entity.Id == 3).Id);
            Assert.Equal(9,entities.First(entity => entity.Id == 9).Id);
            Assert.Equal(5,entities.First(entity => entity.Id == 5).Id);
        }
        private StormyDbContext FakeDbContext()
        {
            var dbContext = TestContext.GetDbContext();
            dbContext.AddRange(GetListData());
            return dbContext;
        }
        private StormyProduct GetSampleData(string sku = Guid.NewGuid().ToString("N"),int? id = null)
        {
            return new StormyProduct
                {
                    SKU = sku,
                    AllowCustomerReview = true,
                    ApprovedRatingSum = 5,
                    ApprovedTotalReviews = 32,
                    AvailableForPreorder = false,
                    Brand = new Brand
                    {
                        Deleted = false,
                        Description = "description",
                        Id = id,
                        LastModified = new DateTime(2019,03,02),
                        LogoImage = "no Image",
                        Name = "A brand"
                    },
                    BrandId = id,
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
                    VendorId = id,
                    Vendor = new StormyVendor
                    {
                        Address = new Address
                        {
                            City = "NoWhere",
                            Complement = "A simple complement",
                            FirstAddress = "first Address",
                            Id = id,
                            LastModified = DateTime.UtcNow,
                            Number = Guid.NewGuid().ToString("N"),
                            PhoneNumber = "9999999-11",
                            PostalCode = "12345678-9",
                            SecondAddress = "Second Address",
                            State = "Hell",
                            Street = "Mcdonalds",
                            ParentId = 1
                        },
                        AddressId = id,
                        CompanyName = "SimpleCompany",
                        ContactTitle = "Simple and a bit trustful",
                        TypeGoods = "Fashion",
                        WebSite = "www.simplecompanyonweb.com",
                        Email = "simplecompany@simpl.com",
                        Id = id,
                        LastModified = DateTime.UtcNow,
                        Logo = "no image",
                        Phone = "8887445512-11",
                        SizeUrl = "www.sizes.com",
                        Note = "Sample Data"
                    },
                    UnitPrice = (decimal)49.99,
                    UnitsInStock = 30,                                                                                
                };           
        }
        public IList<StormyProduct> GetListData()
        {
            return new List<StormyProduct>
            {
                new StormyProduct
                {
                    SKU = "33E386EE-40A9-4AAA-9FA4-E0A196DC10ED",
                    AllowCustomerReview = true,
                    ApprovedRatingSum = 5,
                    ApprovedTotalReviews = 32,
                    AvailableForPreorder = false,
                    Brand = new Brand
                    {
                        Deleted = false,
                        Description = "description",
                        Id = 1,
                        LastModified = new DateTime(2019,03,02),
                        LogoImage = "no Image",
                        Name = "A brand"
                    },
                    BrandId = 7,
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
                            Id = 1,
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
                        Id = 1,
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
                    Id = 7,
                    Ranking = 7,
                    SKU = "33E786EE-40A9-4AAA-9FA4-E0A196DC10ED"
                },
                new StormyProduct{
                    Id = 5,
                    Ranking = 6,
                },
                new StormyProduct{
                    Id = 4,
                    Ranking = 5,
                },
                new StormyProduct{
                    Id = 3,
                    Ranking = 4,
                },
                new StormyProduct{
                    Id = 9,
                    Ranking = 3,
                }
            };
        }
    }
}
