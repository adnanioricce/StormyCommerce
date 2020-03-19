namespace SimplCommerce.Module.Payments.Tests
{
    public class PaymentServiceTest
    {
        [Fact]
        public void ChargeCart_ReceivesObjectWithCartIdUserIdAndOptionalAddressId_ShouldReturnCreatedPaymentEntity()
        {
            //Given 
            var request = new ProcessTransactionRequest{
                CartId = 1,
                UserId = 1,
                AddressId = 1,
                DeliveryCost = 7.00m,
                PaymentMethod = "boleto"
            };
            var fakeUserRepository = new FakeRepository<User>();
            var fakeAddressRepository = new FakeRepository<Address>();
            var fakeCartRepository = new FakeRepository<Cart>();
            var fakePaymentRepository = new FakeRepository<Payment>();
            var paymentProcessor = Mocks.GetFakePaymentProcessor();
            fakeUserRepository.Add(PaymentSeeder.GetUser());
            fakeAddressRepository.Add(PaymentSeeder.GetAddress());
            fakeCartRepository.Add(PaymentSeeder.GetCart());            
            var service = new PaymentService(paymentProcessor,fakeUserRepository,fakeAddressRepository,fakeCartRepository);
            //When 
            var response = service.ChargeCart(request);
            //Then
            Assert.Equal(response.Status == PaymentStatus);
            Assert.NotNull(fakePaymentRepository.Query().FirstOrDefault(p => p.Id == response.PaymentId));
        }   
    }   
}