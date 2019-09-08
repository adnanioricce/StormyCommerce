using System;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos;
using TestHelperLibrary.Utils;
using Xunit;

namespace Modules.Tests.Payments
{
    public class PagarMeServiceTest
    {        
        public PagarMeServiceTest()
        {
            
        }
        private PagarMeService CreateService()
        {
            var mockHttpClient = new Mock<HttpClient>()
            .Setup(f => f.GetAsync(It.IsAny<string>()))
            .Returns(Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK)));
            return new PagarMeService(mockHttpClient,RepositoryHelper.GetRepository<Payment>());
        }
        [Fact]
        public async Task Charge_ReceivesValidatedPaymentDto_ReturnResultWithSuccessEqualTrue()
        {
            //Arrange
            var paymentDto = new PaymentDto{
                
            };
            var service = new PagarMeService();
            //Act
            // var result = service.Get
            //Assert
            Assert.True(false);
        }
    }
}
