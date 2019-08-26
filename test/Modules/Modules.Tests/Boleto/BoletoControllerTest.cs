using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Payments;
using TestHelperLibrary.Utils;
using Xunit;

namespace Modules.Test.Boleto
{
    public class BoletoControllerTest
    {
        private BoletoController _controller;
        public BoletoControllerTest()
        {
            _controller = CreateController();
        }
        private BoletoController CreateController()
        {
            var paymentRepository = RepositoryHelper.GetRepository<Payment>();
            var customerRepository = RepositoryHelper.GetRepository<StormyCustomer>();                   
            return new BoletoController(paymentRepository,customerRepository);
        }
        [Fact]
        public void CheckoutBoleto_AuthenticatedUserAndValidCheckoutBoletoViewModel_ShouldCreateNewBoletoAndOrder()
        {
            //Given
            var boletoVm = new BoletoCheckoutViewModel{

            };            
            //When
            var result = _controller.CheckoutBoleto(boletoVm);
            //Then
            var returnResult = Assert.IsAssignableFrom<OkObjectResult>();
        }
    }
}