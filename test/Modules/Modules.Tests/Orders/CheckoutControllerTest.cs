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
			var controller = new CheckoutController();
			var checkoutObj = new BoletoCheckoutViewModel();			
		    //Act
			var result = controller.CheckoutBoleto(checkoutObj);
		    //Assert
		    Assert.Equal(200,result.Value.StatusCode);
	    }
	    [Fact]
	    public async Task Checkout_ValidInputFromAuthenticatedUser_ReturnOrderToUser()
	    {
		    //Arrange 
		    //Act
		    //Assert
		    Assert.True(false);
	    }
	    [Fact]
	    public async Task CancelOrder_OrderStatusEqualNotShippedAndAuthenticatedUser_CancelOrderAndReturnOk()
	    {
		    //Arrange 
		    //Act
		    //Assert
		    Assert.True(false);
	    }
	    [Fact]
	    public async Task GetOrderById_IdEqual1AndOwnerIsTheAuthenticatedUser_ReturnSpecifiedId()
	    {
		    //Arrange 
		    //Act
		    //Assert
		    Assert.True(false);
	    }
    }
}
