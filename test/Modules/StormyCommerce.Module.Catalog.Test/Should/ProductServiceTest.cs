using System;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using Xunit;
using Moq;
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
        private IStormyRepository<StormyProduct> Repository { get; }
        private IProductService ProductService { get; }        
        public ProductServiceTest()
        {                    
            var context = TestContext.GetDbContext();                                  
            context.AddRange(GetListData());            
            Repository = new StormyRepository<StormyProduct>(context);            
            //Repository = new Mock<IStormyRepository<StormyProduct>>();
            //Repository.Setup(x => x.GetAllAsync())
            //    .ReturnsAsync(collection);
            //Repository.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
            //    .ReturnsAsync(sampleProduct);
            //Repository.Setup(x => x.AddAsync(It.IsAny<StormyProduct>()))
            //    .Returns(Task.FromResult(Task.CompletedTask));
            //Repository.Setup(x => x.AddCollectionAsync(It.IsAny<IEnumerable<StormyProduct>>()))
            //    .Returns(Task.FromResult(Task.CompletedTask));
            //Repository.Setup(x => x.Delete(It.IsAny<StormyProduct>()))
            //    .Callback((StormyProduct entity) => collection.Add(entity));
            //Repository.Setup(x => x.DeleteCollection(It.IsAny<IEnumerable<StormyProduct>>()))
            //    .Callback((IEnumerable<StormyProduct> entities) => collection.RemoveRange(entities));
            //Repository.Setup(x => x.UpdateAsync(It.IsAny<StormyProduct>()))
            //    .Returns(Task.FromResult(Task.CompletedTask));
            //Repository.Setup(x => x.UpdateCollectionAsync(It.IsAny<IEnumerable<StormyProduct>>()))
            //    .Returns(Task.FromResult(Task.CompletedTask));
            //Repository.Setup(x => x.Table)
            //    .Returns(collection);
            //var productService = new ProductService(Repository.Object);                     
            ProductService = new ProductService(Repository);
        }

        [Theory]
        [InlineData(1)]
        public async void GetProductByIdAsync(int id)
        {                        
            //Act
            var entity =  await ProductService.GetProductByIdAsync(id);
            Console.WriteLine(entity);
            //Assert
            Assert.Equal(id,entity.Id);
        }
        [Theory]
        [InlineData("33E386EE-40A9-4AAA-9FA4-E0A196DC10ED")]
        public async void GetProductBySkuAsync(string sku)
        {
            //Act
            var entity = await ProductService.GetProductBySkuAsync(sku);
            //Assert
            Assert.Equal(sku,entity.SKU);
        }
        [Fact]
        public async void GetListProducts()
        {
            //Act
            var entities = await ProductService.GetAllProductsDisplayedOnHomepageAsync(30);
            //Assert
            Assert.Equal(30,entities.Count);
        }

        [Theory]
        [InlineData(new int[] {7,5,4,1,3,9})]
        public async void GetProductsByIds(int[] ids)
        {            
            //Act
            var entities = await ProductService.GetProductsByIdsAsync(ids);
            //Assert
            Assert.Equal(1,entities.First(entity => entity.Id == 1).Id);
            Assert.Equal(7,entities.First(entity => entity.Id == 7).Id);
            Assert.Equal(4,entities.First(entity => entity.Id == 4).Id);
            Assert.Equal(3,entities.First(entity => entity.Id == 3).Id);
            Assert.Equal(9,entities.First(entity => entity.Id == 9).Id);
            Assert.Equal(5,entities.First(entity => entity.Id == 5).Id);
        }
        private StormyProduct GetSampleData()
        {
            return new StormyProduct
                {
                    SKU = "33E353EE-40A9-4AAA-9FA4-E0A196DC10ED",
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
                };           
        }
        public IList<StormyProduct> GetListData()
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
                    SKU = "33E386EE-40A9-4AAA-9FA4-E0A196DC10ED"
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
