using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Models.GatewayResponses;

namespace StormyCommerce.Core.Models.GatewayResponses
{
    public class SignInResponse : BaseIdentityResponse
    {        
        public bool IsLockedOut { get; private set; }
        public bool RequiresTwoFactor { get; private set; }
    }
}