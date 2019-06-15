using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
namespace StormyCommerce.Infraestructure.Entities
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
        public int CustomerId { get; set; }
        public StormyCustomer Customer { get; set; }
    }
}
