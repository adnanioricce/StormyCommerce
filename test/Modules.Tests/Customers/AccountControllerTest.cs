using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Module.Customer.Areas.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Mocks;
using TestHelperLibrary.Utils;
using Xunit;

namespace Modules.Test.Customers
{
    public class AccountControllerTest
    {
        private readonly CustomerController _controller;
        private readonly List<Review> reviews = Seeders.ReviewSeed(15);
        private readonly List<StormyCustomer> customers = Seeders.StormyCustomerSeed(1);
        private readonly StormyCustomer sampleCustomer;

        public AccountControllerTest()
        {
            sampleCustomer = customers.First();
            _controller = CreateController();
        }

        private CustomerController CreateController()
        {
            var service = ServiceTestFactory.GetCustomerService();
            return new CustomerController(service,ServiceTestFactory.GetFakeMapper());
        }

        // private Mock
        [Fact]
        public async Task AddAddressAsync_ReceivesValidAddressVmFromAuthenticatedUser_AddNewAddressRelatedToCustomer()
        {
            //Arrange
            var addressObject = Seeders.AddressSeed().First();
            //Act
            var result = await _controller.AddAddressAsync(addressObject);
            var returnResult = Assert.IsAssignableFrom<OkResult>(result);
            //Assert
            Assert.Equal(200, returnResult.StatusCode);
        }

        [Fact]
        public async Task WriteReviewAsync_AuthenticatedUserSendReview_CreateReviewEntry()
        {
            //Arrange
            var review = new CustomerReviewDto(Seeders.ReviewSeed(1).First());
            //Act
            var result = await _controller.WriteReviewAsync(review);
            var returnResult = Assert.IsAssignableFrom<OkResult>(result);
            //Assert
            Assert.Equal(200, returnResult.StatusCode);
        }

        [Fact]
        public async Task GetCustomers_MinEqual1AndMaxEqual15_ShouldReturnAllCustomerEntitiesBetweenLimits()
        {
            //Arrange
            long limit = 15;
            //Act
            var result = await _controller.GetCustomersAsync(0, limit);
            var returnResult = Assert.IsAssignableFrom<OkResult>(result);
            //Assert
            Assert.Equal(200, returnResult.StatusCode);
            Assert.NotNull(result);
            Assert.True(result.Count > 0 && result.Count <= 15);
        }

        [Fact]
        public async Task GetCustomerByEmail_ReceivesEmailStringAsInput_SearchAndReturnExistingEntityWithGivenEmail()
        {
            //Arrange
            var dbContext = DbContextHelper.GetDbContext();
            var customer = Seeders.StormyCustomerSeed().First();
            dbContext.AddRange(customer);
            dbContext.SaveChanges();
            var customerRepo = RepositoryHelper.GetRepository<StormyCustomer>(dbContext);
            var controller = new CustomerController(new CustomerService(null, customerRepo),null);
            //Act
            var result = await controller.GetCustomerByEmailOrUsernameAsync(customer.Email,"");
            //var contenxt = Assert.

            Assert.Equal(customer.Email, result.Value.Email);
        }

        //[Fact]
        //public async Task EditCustomerReview_ReceivesReviewFromAuthenticatedUser_ChangeStateOfEntityOnContext()
        //{
        //    //Arrange
        //    var review = new CustomerReviewDto(Seeders.ReviewSeed(1).First());
        //    var claimPrincipal = new System.Security.Claims.ClaimsPrincipal();

        //    _controller.ControllerContext.HttpContext.User = claimPrincipal;
        //    //Act
        //    var result = await _controller.EditCustomerReview(review);
        //    var returnResult = Assert.IsAssignableFrom<OkResult>(result);
        //    //Assert
        //    Assert.Equal(200, returnResult.StatusCode);
        //}
    }
}
