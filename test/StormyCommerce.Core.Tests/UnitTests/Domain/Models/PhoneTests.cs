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
            string phonenumber = "55110123456789";            
            //When
            var phone = new Phone(phonenumber);
            //Then
            string ddi = $"{phonenumber[0]}{phonenumber[1]}";
            string dd = $"{phonenumber[2]}{phonenumber[3]}";
            string number = phonenumber.Substring(3);
            // Assert.Equal(ddi,)
        }
    }
}
