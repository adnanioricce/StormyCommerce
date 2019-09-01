using Microsoft.AspNetCore.Mvc;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Module.Orders.Area.Controllers;
using System.Threading.Tasks;
using Xunit;
namespace Modules.Test.Orders
{
    public class CheckoutControllerTest
    {
	    [Fact]
	    public async Task CheckoutBoleto_ValidInputFromAuthenticatedUser_ShouldReturnOrderAndBoletoToUser()
	    {
		    //Arrange 
			var controller = new CheckoutController(null,null);
			var checkoutObj = new BoletoCheckoutViewModel();			
		    //Act
			var result = await controller.CheckoutBoleto(checkoutObj);
            //Assert
            var returnResult = Assert.IsAssignableFrom<OkResult>(result);
            Assert.Equal(200, returnResult.StatusCode);
	    }
	    //[Fact]
	    //public async Task Checkout_ValidInputFromAuthenticatedUser_ReturnOrderToUser()
	    //{
		   // //Arrange 
		   // //Act
		   // //Assert
		   // Assert.True(false);
	    //}
	    //[Fact]
	    //public async Task CancelOrder_OrderStatusEqualNotShippedAndAuthenticatedUser_CancelOrderAndReturnOk()
	    //{
		   // //Arrange 
		   // //Act
		   // //Assert
		   // Assert.True(false);
	    //}
	    //[Fact]
	    //public async Task GetOrderById_IdEqual1AndOwnerIsTheAuthenticatedUser_ReturnSpecifiedId()
	    //{
		   // //Arrange 
		   // //Act
		   // //Assert
		   // Assert.True(false);
	    //}
    }
}
