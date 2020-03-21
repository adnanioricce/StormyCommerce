using System;
using System.Linq;
using Moq;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Module.Payments.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Tests;
using Xunit;

namespace SimplCommerce.Module.Payments.Tests
{
    public class PaymentProcessorTest
    {
        [Fact]
        public void ProcessTransaction_ReceivesProcessTransactionRequestWithCardPaymentMethod_ReturnProcessTransactionResponseWithStatusAndPaymentInformation()
        {
            //Given
            var request = new ProcessTransactionRequest {
                CartId = 1,          
                AddressId = 1,
                UserId = 1,                      
                DeliveryCost = 7.00m,
                PaymentMethod = "credit_card",
                CardBrand = "visa",
                CardCountry = "US",
                CardExpirationMounth = "8",
                CardExpirationYear = "2021",
                CardFingerPrint = "",
                CardFunding = "credit"  

            };
            var fakePaymentRepository = new FakeRepository<Payment>();
            var fakeAddressRepo = new FakeRepository<Address>();            
            var fakeCartRepository = new FakeRepository<Cart>();
            var cart = PaymentSeeder.GetCart();
            var billingAddress = PaymentSeeder.GetAddress();
            var user = PaymentSeeder.GetUser();                       
            fakeAddressRepo.Add(billingAddress);            
            fakeCartRepository.Add(cart);
            var fakeProvider = new Mock<IPaymentProvider>().Object;
            var service = new PaymentProcessor(fakeProvider,fakePaymentRepository,fakeCartRepository); 
            //When 
            var response = service.ProcessTransaction(request);
            //Then
            Assert.True(response.Success);
            //TODO:Should be good test if tax amount is being applied
            var payment = fakePaymentRepository.Query().FirstOrDefault(p => p.Id == response.PaymentId);
            Assert.Equal(24.00m + 7.00m,payment.Amount);
        }
        [Fact]
        public void ProcessTransaction_ReceivesProcessTransactionRequestWithBoletoPaymentMethod_ReturnProcessTransactionResponseWithStatusAndPaymentInformationAndBoletoUrl()
        {
            //Given
            var request = new ProcessTransactionRequest{
                CartId = 1,
                AddressId = 1,
                UserId = 1,
                DeliveryCost = 7.00m,
                PaymentMethod = "boleto"                
            };
            var fakePaymentRepository = new FakeRepository<Payment>();            
            var fakeAddressRepo = new FakeRepository<Address>();
            var fakeCartRepository = new FakeRepository<Cart>();            
            fakeAddressRepo.Add(PaymentSeeder.GetAddress());            
            var fakeProvider = new Mock<IPaymentProvider>().Object;
            var service = new PaymentProcessor(fakeProvider,fakePaymentRepository,fakeCartRepository);
            //when 
            var response = service.ProcessTransaction(request);
            //Then
            var payment = fakePaymentRepository.Query().FirstOrDefault(p => p.Id == response.PaymentId);
            Assert.True(response.Success);
            Assert.Equal(24.00m + request.DeliveryCost,payment.Amount);            
        }                
    }
}
