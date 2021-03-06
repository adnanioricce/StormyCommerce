﻿using System.Collections.Generic;
using System.Security.Claims;

namespace StormyCommerce.Module.Customer.Services
{
    //? Ask yourself:I really need to create a interface for each service/repository and so on?
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);

        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
