using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.Controllers;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models.Requests;
using System;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Extensions;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    [TestCaseOrderer("AccountManagement", "OrderStrategyAssemblyName")]
    public class AccountControllerTest
    {
        private readonly AccountController _controller;
        private readonly UserManager<User> _userManager;
        private readonly IUserIdentityService _identityService;        
        public AccountControllerTest(IUserIdentityService identityService,
            IEmailSender emailSender,
            IAppLogger<AccountController> logger,            
            IMapper mapper,            
            UserManager<User> userManager)
        {
            _controller = new AccountController(identityService, emailSender, logger,mapper);
            _userManager = userManager;
            _identityService = identityService;            
            _controller.ControllerContext = _userManager.CreateTestContext();            
        }        
        [Fact,TestPriority(-1)]
        
        public async Task ConfirmEmailAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange      
            var user = _userManager.Users.FirstOrDefault();
            user.EmailConfirmed = false;
            long userId = user.Id;
            string code = await _identityService.CreateEmailConfirmationCode(user);

            // Act
            var response = await _controller.ConfirmEmailAsync(userId,code);
            var result = response as OkObjectResult;
            // Assert
            Assert.Equal(200,(int)result.StatusCode);
        }

        [Fact,TestPriority(2)]
        public async Task ResetPasswordAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var user = _userManager.Users.FirstOrDefault(u => string.Equals(u.Email, "adnangonzaga@gmail.com", StringComparison.OrdinalIgnoreCase));
            var model = new ResetPasswordViewModel {                 
                Code = await _identityService.GeneratePasswordResetTokenAsync(user),
                Email = user.Email,
                Password = "!D4vpassword",
                ConfirmPassword = "!D4vpassword"
            };

            // Act
            var response = await _controller.ResetPasswordAsync(model);
            var statusResult = response as OkObjectResult;

            // Assert
            Assert.Equal(200,(int)statusResult.StatusCode);
        }

        [Fact,TestPriority(2)]
        public async Task AddDefaultShippingAddress_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var model = new CreateShippingAddressRequest {
                Address = new Core.Entities.Common.AddressDetail("br", 
                "são paulo",
                "cidade",
                "bairro",
                "endereço",
                "primeiro endereço",
                "segundo endereço",
                "123456789",
                "numero",
                "complemento",
                "",
                ""),
                Type = AddressType.Shipping,
                WhoReceives = "adnan"
            };

            // Act
            var response = await _controller.AddDefaultShippingAddress(model);
            var result = response as OkObjectResult;
            // Assert
            Assert.Equal(200,(int)result.StatusCode);
        }

        [Fact,TestPriority(-3)]       
        public async Task EditAccount_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var request = new EditCustomerRequest { 
                CPF = "123456789",
                DateOfBirth = DateTimeOffset.UtcNow.Add(DateTimeOffset.UtcNow.Subtract(DateTimeOffset.UtcNow.AddYears(18))),                
                FullName = "Aguinobaldo Silva",
                PhoneNumber = "+55111234567",
                UserName = "adnanioricce"
                
            };
            _controller.ControllerContext = _userManager.CreateTestContext(_userManager.GetCustomerForEditOperations());
            // Act
            var response = await _controller.EditAccount(request);
            var statusResult = response as OkObjectResult;
            var result = statusResult.Value as Result;
            // Assert
            Assert.Equal(200,(int)statusResult.StatusCode);
            Assert.True(result.Success);
        }

        [Fact,TestPriority(1)]        
        public async Task EditAddress_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var request = new EditCustomerAddressRequest
            {
                Address = new Core.Entities.Common.AddressDetail("br",
                "são paulo",
                "cidade",
                "bairro",
                "endereço",
                "primeiro endereço",
                "segundo endereço",
                "123456789",
                "numero",
                "complemento",
                "",
                ""),
                WhoReceives = "aguinobaldo"
            };

            // Act
            var response = await _controller.EditAddress(request);
            var statusResult = response as OkObjectResult;
            var result = response as Result;
            // Assert
            Assert.Equal(200,(int)statusResult.StatusCode);
        }

        [Fact,TestPriority(-1)]
        public async Task ResendConfirmationEmail_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            

            // Act
            var response = await _controller.ResendConfirmationEmail();
            var statusResult = response as OkObjectResult;
            var result = statusResult.Value as Result<string>;
            // Assert
            Assert.Equal(200,(int)statusResult.StatusCode);
            Assert.True(result.Success);
        }

        [Fact,TestPriority(-2)]
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
        [Fact,TestPriority(5)]
        public async Task DeleteAccount_ReceivesPassword_ShouldReturnA200Status()
        {
            //Arrange 
            string password = "!D4velopment";
            //Act 
            var response = await _controller.DeleteAccount(password);
            //Assert 
            var result = response as OkObjectResult;
            Assert.Equal(200, (int)result.StatusCode);
        }
        //[Fact,TestPriority(4)]
        //public async Task DeleteAddress_ReceivesAddressId_Return200StatusCode()
        //{
        //    var currentUser = await _controller.GetCurrentCustomer();
        //    //Act 
        //    var response = await _controller.DeleteAddress(currentUser.Addresses.First().Id);
        //    //Assert
        //    var result = response as OkObjectResult;
        //    Assert.Equal(200, (int)result.StatusCode);
        //}
    }
}
