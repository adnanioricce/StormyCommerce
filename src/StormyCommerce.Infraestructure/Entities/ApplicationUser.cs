using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Infraestructure.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string RefreshTokenHash { get; set; }
        public IdentityRole Role { get; set; }
    }
}
