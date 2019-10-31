using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Customers
{
    public class CustomerServiceTest
    {
        #region Variables                
        private readonly StormyCustomer sampleCustomer = Seeders.StormyCustomerSeed().First();          
        #endregion
        public CustomerServiceTest()
        {
            // _service = ServiceTestFactory.GetCustomerService(true);
            sampleCustomer.Id = 0;
        }
        #region Private Helper Methods        
        private ICustomerService CreateCustomerService(StormyDbContext context)
        {            
            var reviewRepo = new StormyRepository<Review>(context);
            var customerRepo = new StormyRepository<StormyCustomer>(context);
            return new CustomerService(reviewRepo, customerRepo);
        }        
        #endregion
        #region Expected Scenario
        #region Read Operations
        [Fact]
        public async Task GetCustomerReviewsAsync_ExistingEntityWithIdEqual1And2Reviews_ReturnAllReviewsCreatedByTheCustomer()
        {
            //Given    
            var customer = Seeders.StormyCustomerSeed().First();        
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.Add(customer);
            context.SaveChanges();
            var service = CreateCustomerService(context);
            //When
            var reviews = await service.GetCustomerReviewsAsync(customer.Id);
            //Then
            Assert.Equal(1, reviews.Count);
        }
        [Fact]
        public async Task GetCustomerReviewByIdAsync_ReviewCreatedByUserWithGivenId_ReturnGivenEntityCreatedByCustomer()
        {
            //Given
            var customer = Seeders.StormyCustomerSeed().First();
            var entryReview = customer.CustomerReviews.First();
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.Add(customer);
            var service = CreateCustomerService(context);
            //When
            var review = await service.GetCustomerReviewByIdAsync(customer.UserId,entryReview.Id);            
            //Then
            Assert.Equal(entryReview.Id, review.Id);
        }
        [Fact]
        public void GetCustomersCount_NoInputDatabase_ReturnNumberEntiesOnTheGivenTable()
        {
            //Arrange 
            var dbContext = DbContextHelper.GetDbContext();
            var seed = Seeders.StormyCustomerSeed(4);
            var service = new CustomerService(null, RepositoryHelper.GetRepository<StormyCustomer>(dbContext,seed));
            //Act 
            var count = service.GetCustomersCount();
            //Assert
            Assert.Equal(4, count);
        }
        [Theory]
        [InlineData(0,15)]
        [InlineData(0,0)]
        [InlineData(7,8)]
        [InlineData(-1,3)]
        public async Task GetAllCustomerAsync_ReceivesMinAndMaxLimitValues_ReturnAllEntriesBetweenGivenRange(long minLimit,long maxLimit)
        {
            //Arrange             
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.AddRange(Seeders.StormyCustomerSeed(2));
            context.SaveChanges();
            var service = CreateCustomerService(context);            
            //Act
            var customers = await service.GetAllCustomersAsync(minLimit, maxLimit);

            //Assert             
            Assert.True(customers.Count <= maxLimit);
        }
        [Fact]        
        public async Task GetCustomerByEmailOrUsername_ReceivesEmail_ReturnCustomerWithGivenEmail()
        {
            //Arrange                   
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.Add(sampleCustomer);
            context.SaveChanges();
            var service = CreateCustomerService(context);            
            //Act
            var customer = await service.GetCustomerByUserNameOrEmail("",sampleCustomer.Email);
            //Assert
            Assert.Equal(sampleCustomer.Email,customer.Email);
        }
        [Fact]
        public async Task GetCustomerByEmailOrUsername_ReceivesUsername_ReturnCustomerWithGivenUsername()
        {
            //Arrange                               
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.Add(sampleCustomer);
            context.SaveChanges();
            var service = CreateCustomerService(context);     
            //Act
            var customer = await service.GetCustomerByUserNameOrEmail(sampleCustomer.UserName, "");
            //Assert
            Assert.Equal(sampleCustomer.UserName, customer.UserName,true);
        }
        #endregion
        #region Create and Update Operations
        [Fact]
        public async Task CreateCustomerReview_PassingValidCustomerReviewDto_ShouldCreateNewEntryOnDatabase()
        {
            //Arrange
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            var customer = Seeders.StormyCustomerSeed().FirstOrDefault();
            context.AddRange(customer);
            context.SaveChanges();
            var service = CreateCustomerService(context);     
            var review = new Review
            {
                Id = 11,
                IsDeleted = false,
                Comment = "a simple comment",
                Title = "a title",
                ReviewerName = "simple name",
            };
            //Act
            await service.CreateCustomerReviewAsync(review, customer.Email);

            var createdReview = context.Find<Review>(review.Id);
            //Assert
            Assert.Equal(review.Id, createdReview.Id);            
        }
        [Fact]
        public async Task CreateCustomerAsync_ReceivesCustomerEntityObject_ShouldCreateNewCustomer()
        {
            //Arrange            
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            var service = CreateCustomerService(context);     
            var customer = Seeders.StormyCustomerSeed().First();
            customer.Id = 0;            
            //Act
            await service.CreateCustomerAsync(customer);            
            //Assert
            var createdCustomer = context.Find<StormyCustomer>(customer.Id);
            Assert.Equal(customer.Id, createdCustomer.Id);
        }
        [Fact]
        public async Task AddCustomerAddressAsync_PassAddressEntityAndCustomerId_CreateAddressEntryRelatedToGivenCustomerId()
        {
            //Arrange
            var address = Seeders.AddressSeed().First();            
            long customerId = 1;            
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.AddRange(sampleCustomer);
            context.SaveChanges();
            var service = CreateCustomerService(context);     
            //Act
            await service.AddCustomerAddressAsync(address, customerId);
            //Assert
        }
        [Fact]
        public async Task EditCustomerReviewAsync_ReceivesEntityWithIdEqualExistingEntity_WriteChangesFromGivenEntityToExistingEntity()
        {
            //Given
            var givenReview = sampleCustomer.CustomerReviews.First();            
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.Add(sampleCustomer);                        
            context.SaveChanges();
            var service = CreateCustomerService(context);     
            var oldReviewStatus = givenReview.Status;
            //When
            givenReview.Status = ReviewStatus.Pending;
            await service.EditCustomerReviewAsync(givenReview, sampleCustomer.Id);
            //Then
            var editedReview = await service.GetCustomerReviewByIdAsync(sampleCustomer.UserId, givenReview.Id);
            Assert.Equal(givenReview.Id, editedReview.Id);
            Assert.NotEqual(oldReviewStatus, editedReview.Status);            
        }
        #endregion
        #region Delete Operations
        [Fact]
        public async Task DeleteCustomerReviewByIdAsync_GivenIdFromExistingEntity_SetIsDeletedFieldToTrue()
        {
            //Arrange 
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            context.AddRange(Seeders.ReviewSeed());
            context.SaveChanges();
            var service = CreateCustomerService(context);     
            

            //Act
            await service.DeleteCustomerReviewByIdAsync(1, sampleCustomer.Id);
            var entry = await service.GetCustomerReviewByIdAsync(sampleCustomer.UserId, 1);
            //Assert
            Assert.True(entry.IsDeleted);
        }

       

        [Fact]
        public async Task DeleteCustomerByIdAsync_ReceivesIdFromExistingStormyCustomerEntity_SetIsDeletedToTrue()
        {
            //Arrange
            long customerId = 1;            
            var customer = Seeders.StormyCustomerSeed().First();
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            customer.Id = customerId;
            context.AddRange(customer);
            var service = CreateCustomerService(context);                 
            await service.CreateCustomerAsync(customer);
            //Act
            await service.DeleteCustomerByIdAsync(customerId);
            var deletedCustomer = await service.GetCustomerByIdAsync(customerId);
            //Assert
            Assert.True(deletedCustomer.IsDeleted);
        }
        #endregion
        #endregion
    }
}
