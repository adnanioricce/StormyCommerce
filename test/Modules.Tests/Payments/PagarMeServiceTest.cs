using Moq;
using PagarMe;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.PagarMe.Services;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace Modules.Tests.Payments
{
    public class PagarMeServiceTest
    {
        public PagarMeServiceTest()
        {
        }

        private StormyPagarmeService CreateService()
        {
            var mockPagarme = new Mock<PagarMeService>();
            //mockPagarme.Setup(f => f.Transactions.)

            return new StormyPagarmeService(RepositoryHelper.GetRepository<Payment>(),null);
        }

        [Fact]
        public async Task Charge_ReceivesValidatedPaymentDto_ReturnResultWithSuccessEqualTrue()
        {
            //Arrange
            var paymentDto = new PaymentDto
            {
            };
            var service = CreateService();
            //Act
            // var result = service.Get
            //Assert
            Assert.True(false);
        }
    }
}
