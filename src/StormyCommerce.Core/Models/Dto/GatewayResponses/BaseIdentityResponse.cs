using Microsoft.AspNetCore.Identity;

namespace StormyCommerce.Core.Models.GatewayResponses
{
    
    public abstract class BaseIdentityResponse
    {
        public bool Failed { get; set; }
        public bool Success { get; set; }
        public bool NotAllowed { get; set; }
    }
}