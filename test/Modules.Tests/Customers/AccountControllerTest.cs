using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Common;
using Xunit;
using StormyCommerce.Module.Customer.Area.Controllers;
namespace Modules.Test.Customers
{
    public class AccountControllerTest
    {       
        private readonly AccountController _controller;
        private AccountController CreateController()
        {

        }
        // private          
        public AccountControllerTest()
        {
            
        }
        // private Mock
        [Fact]
        public async Task AddAddressAsync_ReceivesValidAddressVmFromAuthenticatedUser_AddNewAddressRelatedToCustomer()
        {
            //Arrange
            var addressObject = Seeders.AddressSeed().First();            
            //Act
            // var result = 
            //Assert
        }        
        [Fact]
        public async Task WriteReviewAsync_AuthenticatedUserSendReview_CreateReviewEntry()
        {
            // var review = 
        }
        // [Fact]
        // public async Task AddPaymentAsync_ReceivesValidPaymentVmF()
        // {
        //     //Arrange
        
        //     //Act
        
        //     //Assert
        // }


    }
}