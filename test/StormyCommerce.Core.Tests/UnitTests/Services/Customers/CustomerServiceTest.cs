using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Mocks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Customers
{
    public class CustomerServiceTest
    {
        private readonly ICustomerService _service;
        private readonly DbContextOptions<StormyDbContext> _dbContextOptions = DbContextHelper.GetDbOptions();
        private readonly StormyCustomer sampleCustomer = Seeders.StormyCustomerSeed().First();
        private readonly Review sampleReview = Seeders.ReviewSeed(1).First();

        public CustomerServiceTest()
        {
            _service = ServiceTestFactory.GetCustomerService(RepositoryHelper.GetRepository<Review>(), RepositoryHelper.GetRepository<StormyCustomer>());
        }

        private ICustomerService CreateCustomerService(bool withSeed)
        {
            var context = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions());
            if (withSeed)
            {
                var reviews = Seeders.ReviewSeed(10);
                reviews.ForEach(f => f.StormyCustomerId = sampleCustomer.Id);
                context.AddRange(sampleCustomer);
                context.SaveChanges();
                context.AddRange(reviews);
                context.SaveChanges();
            }
            else
            {
                context.Add(sampleCustomer);
                context.SaveChanges();
            }
            var reviewRepo = new StormyRepository<Review>(context);
            var customerRepo = new StormyRepository<StormyCustomer>(context);
            return new CustomerService(reviewRepo, customerRepo);
        }

        [Fact]
        public async Task CreateCustomerReview_PassingValidCustomerReviewDto_ShouldCreateNewEntryOnDatabase()
        {
            //Arrange
            var service = CreateCustomerService(false);
            var review = new Review
            {
                Id = 11,
                IsDeleted = false,
                Comment = "a simple comment",
                Title = "a title",
                ReviewerName = "simple name",
            };
            //Act
            await service.CreateCustomerReviewAsync(review, sampleCustomer.Email.ToUpper());

            var createdReview = await service.GetCustomerReviewByIdAsync(sampleCustomer.Id, review.Id);
            //Assert
            Assert.Equal(review.Id, createdReview.Id);
            //Assert.Equal(review.Title, createdReview);
        }

        [Fact]
        public async Task GetCustomerReviewsAsync_ExistingEntityWithIdEqual1And2Reviews_ReturnAllReviewsCreatedByTheCustomer()
        {
            //Given
            long id = 1;
            //When
            var reviews = await _service.GetCustomerReviewsAsync(id);
            //Then
            Assert.Equal(10, reviews.Count);
        }

        [Fact]
        public async Task GetCustomerReviewByIdAsync_ReviewCreatedByUserWithGivenId_ReturnGivenEntityCreatedByCustomer()
        {
            //Given
            long reviewId = 1;
            long customerId = 1;
            //When
            var review = await _service.GetCustomerReviewByIdAsync(customerId, reviewId);
            //Then
            Assert.Equal(reviewId, review.Id);
        }

        [Fact]
        public async Task EditCustomerReviewAsync_ReceivesEntityWithIdEqualExistingEntity_WriteChangesFromGivenEntityToExistingEntity()
        {
            //Given
            var givenReview = Seeders.ReviewSeed(1).First();
            //When
            await _service.EditCustomerReviewAsync(givenReview, sampleCustomer.Id);
            //Then
            var editedReview = await _service.GetCustomerReviewByIdAsync(sampleCustomer.Id, givenReview.Id);
            Assert.Equal(givenReview.Id, editedReview.Id);
            Assert.NotEqual(givenReview.LastModified, editedReview.LastModified);
            //Assert.Equal(givenReview.StormyCustomerId,editedReview.StormyCustomerId);
        }

        [Fact]
        public async Task DeleteCustomerReviewByIdAsync_GivenIdFromExistingEntity_SetIsDeletedFieldToTrue()
        {
            //Act
            await _service.DeleteCustomerReviewByIdAsync(1, sampleCustomer.Id);
            var entry = await _service.GetCustomerReviewByIdAsync(sampleCustomer.Id, 1);
            //Assert
            Assert.True(entry.IsDeleted);
        }

        [Fact]
        public async Task CreateCustomerAsync_ReceivesCustomerEntityObject_ShouldCreateNewCustomer()
        {
            //Arrange
            var service = new CustomerService(RepositoryHelper.GetRepository<Review>(), RepositoryHelper.GetRepository<StormyCustomer>());
            var customer = Seeders.StormyCustomerSeed().First();
            customer.Id = 0;

            //Act
            await service.CreateCustomerAsync(customer);
            // var entry = _service.ge
            var entry = service.GetCustomerByIdAsync(customer.Id);
            //Assert
            Assert.Equal(customer.Id, entry.Id);
        }

        [Fact]
        public async Task AddCustomerAddressAsync_PassAddressEntityAndCustomerId_CreateAddressEntryRelatedToGivenCustomerId()
        {
            //Arrange
            var address = Seeders.AddressSeed().First();
            long customerId = 1;
            //Act
            await _service.AddCustomerAddressAsync(address, customerId);
            //Assert
        }

        [Fact]
        public async Task DeleteCustomerByIdAsync_ReceivesIdFromExistingStormyCustomerEntity_SetIsDeletedToTrue()
        {
            //Arrange
            long customerId = 1;
            //Act
            await _service.DeleteCustomerByIdAsync(customerId);
            var customer = await _service.GetCustomerByIdAsync(customerId);
            //Assert
            Assert.True(customer.IsDeleted);
        }
    }
}
