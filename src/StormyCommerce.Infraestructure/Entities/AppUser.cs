using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Infraestructure.Entities
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
        public int CustomerId { get; set; }
    }
}
