using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Entities.Customer
{
    public class Phone 
    {        
        public Phone()
        {
            
        }
        public Phone(string phoneNumber)
        {
            var ddChars = new string(phoneNumber.Take(2).ToArray());
            var ddiChars = new string(phoneNumber.Substring(1).Take(2).ToArray());
            // DD = phoneNumber.Reverse().Substring(phoneNumber.Length-2)
        }
        public string DD { get; set; }
        public string DDI { get; set; }
        public string Number { get; set; }
    }
}