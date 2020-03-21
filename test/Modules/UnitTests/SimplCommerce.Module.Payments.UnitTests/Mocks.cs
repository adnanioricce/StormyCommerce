using Moq;
using SimplCommerce.Module.Payments.Interfaces;

namespace SimplCommerce.Module.Payments.Tests
{
    public static class Mocks
    {
        public static IPaymentProcessor GetFakePaymentProcessor()
        {
            var mockProcessor = new Mock<IPaymentProcessor>();
            return mockProcessor.Object;
        }   
    }   
}
