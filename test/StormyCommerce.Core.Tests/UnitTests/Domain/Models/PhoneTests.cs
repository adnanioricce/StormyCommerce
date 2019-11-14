using StormyCommerce.Core.Entities.Customer;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Domain.Models
{
    public class PhoneTests
    {
        [Fact]
        public void PhoneConstructor_ReceivesString_ShouldConvertStringToValidPhoneWithDDI_DD_And_Number()
        {
            //Given
            string ddi = "55";
            // string
            string phonenumber = "55110123456789";            
            //When
            var phone = new Phone(phonenumber);
            //Then
            // Assert.Equal
        }
    }
}
