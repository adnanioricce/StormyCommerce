using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Services.Customer;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Customers
{
    public class CustomerServiceTest
    {
        private readonly ICustomerService _service;
        private readonly IStormyRepository<Review> _reviewRepository;
        private readonly IStormyRepository<StormyCustomer> _customerRepository;

        public CustomerServiceTest()
        {
            _reviewRepository = RepositoryHelper.GetRepository<Review>();
            _customerRepository = RepositoryHelper.GetRepository<StormyCustomer>();
            _service = new CustomerService(_reviewRepository, _customerRepository);
        }

        [Fact]
        public async Task CreateCustomerReview_PassingValidCustomerReviewDto_ShouldCreateNewEntryOnDatabase()
        {
            //Arrange
            var reviewDto = new CustomerReviewDto();
            //Act
            await _service.CreateCustomerReviewAsync(reviewDto);
            var createdReview = await _reviewRepository.GetByIdAsync(1);
            //Assert
            Assert.Equal(reviewDto.Id, createdReview.Id);
        }

        [Fact]
        public async Task GetCustomerReviewsAsync_ExistingEntityWithIdEqual1And2Reviews_ReturnAllReviewsCreatedByTheCustomer()
        {
            //Given
            long id = 1;
            //When
            var reviews = await _service.GetCustomerReviewsAsync(id);
            //Then
            Assert.Equal(2, reviews.Count);
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
            var givenReview = new Review();
            //When
            await _service.EditCustomerReviewAsync(givenReview);
            //Then
            var editedReview = await _reviewRepository.GetByIdAsync(1);
            Assert.Equal(givenReview.Id, editedReview.Id);
        }

        [Fact]
        public async Task DeleteCustomerReviewByIdAsync_GivenIdFromExistingEntity_SetIsDeletedFieldToTrue()
        {
            //Arrange
            long reviewId = 1;
            long customerId = 1;
            //Act
            await _service.DeleteCustomerReviewByIdAsync(reviewId);
            //Assert
            var entry = await _service.GetCustomerReviewByIdAsync(customerId, reviewId);
            Assert.Null(entry);
        }

        [Fact]
        public async Task CreateCustomerAsync_ReceivesCustomerEntityObject_ShouldCreateNewCustomer()
        {
            //Arrange
            var customer = Seeders.StormyCustomerSeed().First();
            customer.Id = _customerRepository.Table.Count() + 1;
            //Act
            await _service.CreateCustomerAsync(customer);
            var createdCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            //Assert
            Assert.Equal(customer.Id, createdCustomer.Id);
        }

        [Fact]
        public async Task AddCustomerAddressAsync_PassAddressEntityAndCustomerId_CreateAddressEntryRelatedToGivenCustomerId()
        {
            //Arrange
            var address = Seeders.AddressSeed().First();
            long customerId = 1;
            //Act
            await _service.AddCustomerAddressAsync(address, customerId);
            var resultOnCustomerTable = await _customerRepository.GetByIdAsync(customerId);
            // var resultOnAddressTable =
            //Assert
            Assert.Equal(customerId, resultOnCustomerTable.Id);
            Assert.Contains(address, resultOnCustomerTable.CustomerAddresses);
        }

        [Fact]
        public async Task DeleteCustomerByIdAsync_ReceivesIdFromExistingStormyCustomerEntity_SetIsDeletedToTrue()
        {
            //Arrange
            long customerId = 1;
            long countTable = _customerRepository.Table.Count();
            //Act
            await _service.DeleteCustomerByIdAsync(customerId);
            var customer = await _customerRepository.GetByIdAsync(customerId);
            var currentCountTable = _customerRepository.Table.Count();
            //Assert
            Assert.Equal(countTable - 1, currentCountTable);
            Assert.Null(customer);
        }
    }
}
