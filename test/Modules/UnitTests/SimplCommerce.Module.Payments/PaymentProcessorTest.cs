using System;
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
                CardExpirationMounth = 8,
                CardExpirationYear = 2021,
                CardFingerPrint = "",
                CardFunding = "credit"  

            };
            var fakePaymentRepository = new FakeRepository<Payment>();
            var fakeAddressRepo = new FakeRepository<Address>();
            var fakeUserRepository = new FakeRepository<User>();
            var fakeCartRepository = new FakeRepository<Cart>();
            var cart = PaymentSeeder.GetCart();
            var billingAddress = PaymentSeeder.GetAddress();
            var user = PaymentSeeder.GetUser();           
            fakeUserRepository.Add(user);
            fakeAddressRepo.Add(billingAddress);            
            fakeCart.Add(cart);
            var fakeProvider = new Moq<IPaymentProvider>().Object;
            var service = new PaymentProcessor(fakeProvider,fakePaymentRepository,fakeCartRepository); 
            //When 
            var response = service.ProcessTransaction(request);
            //Then
            Assert.True(response.Success);
            //TODO:Should be good test if tax amount is being applied
            Assert.Equal(24.00m + 7.00m,response.TotalCost);
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
            var fakeUserRepository = new FakeRepository<User>();
            var fakeCartRepository = new FakeRepository<Cart>();
            fakeUserRepository.Add(PaymentSeeder.GetUser());
            fakeAddressRepo.Add(PaymentSeeder.GetAddress());
            fakeCart.Add(PaymentSeeder.GetCart());
            var fakeProvider = new Moq<IPaymentProvider>().Object;
            var service = new PaymentProcessor(fakeProvider,fakePaymentRepository,fakeCartRepository);
            //when 
            var response = service.ProcessTransaction(request);
            //Then
            Assert.True(response.Success);
            Assert.Equal(24.00m + request.DeliveryCost,response.TotalCost);            
        }                
    }
}