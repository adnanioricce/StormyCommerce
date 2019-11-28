using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.Controllers;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models.Requests;
using System.Threading.Tasks;
using TestHelperLibrary.Extensions;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class AccountControllerTest
    {
        private readonly AccountController _controller;
        private readonly UserManager<StormyCustomer> _userManager;
        public AccountControllerTest(IUserIdentityService identityService,
            IEmailSender emailSender,
            IAppLogger<AccountController> logger,            
            IMapper mapper,
            UserManager<StormyCustomer> userManager)
        {
            _controller = new AccountController(identityService, emailSender, logger, mapper);
            _userManager = userManager;
            _controller.ControllerContext = _userManager.CreateTestContext();
        }
        [Fact]
        public async Task ConfirmEmailAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            string userId = null;
            string code = null;

            // Act
            var result = await _controller.ConfirmEmailAsync(
                userId,
                code);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task ResetPasswordAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            ResetPasswordViewModel model = new ResetPasswordViewModel { 
                
            };

            // Act
            var result = await _controller.ResetPasswordAsync(
                model);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddDefaultShippingAddress_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var model = new CreateShippingAddressRequest {
                Address = new Core.Entities.Common.Address("br", "são paulo",
                "cidade",
                "bairro",
                "endereço",
                "primeiro endereço",
                "segundo endereço",
                "123456789",
                "numero",
                "complemento"),
                IsBillingAddress = false,
                WhoReceives = "adnan"
            };

            // Act
            var response = await _controller.AddDefaultShippingAddress(model);
            var result = response as OkObjectResult;
            // Assert
            Assert.Equal(200,(int)result.StatusCode);
        }

        [Fact]
        public async Task EditAccount_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            EditCustomerRequest request = null;

            // Act
            var result = await _controller.EditAccount(request);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task EditAddress_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            EditCustomerAddressRequest request = null;

            // Act
            var result = await _controller.EditAddress(request);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task ResendConfirmationEmail_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            

            // Act
            var result = await _controller.ResendConfirmationEmail();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCurrentCustomer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            
            // Act
            var result = await _controller.GetCurrentCustomer();

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Email);
            Assert.Equal("adnangonzaga@gmail.com", result.Email);
        }
    }
}
