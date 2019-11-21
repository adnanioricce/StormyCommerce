using System;

namespace StormyCommerce.Module.Customer.Models
{
    public class AuthResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTimeOffset ExpiresIn { get; set; }
    }
}
