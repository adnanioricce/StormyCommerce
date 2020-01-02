using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using StormyCommerce.Core.Entities;

namespace TestHelperLibrary.Utils
{
    public static class IdentityTestUtils
    {
        public static IEnumerable<Claim> GetClaims(User user)
        {
            return new[]{
                new Claim(JwtRegisteredClaimNames.Sub, user.UserGuid.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Iat, value: DateTimeOffset.UtcNow.ToString("yyyy-MM-dd")),
                new Claim(ClaimTypes.Role,user.Roles.FirstOrDefault().Role.Name)
                };
        }
        public static ClaimsIdentity GetClaimsIdentity(IEnumerable<Claim> claims,string authType)
        {
            return new ClaimsIdentity(claims, authType);
        }
        public static ClaimsPrincipal GetClaimsPrincipal(ClaimsIdentity identity)
        {
            return new ClaimsPrincipal(identity);
        }
        public static ClaimsPrincipal GetClaimsPrincipal(User user)
        {
            var claims = GetClaims(user);
            var identity = new ClaimsIdentity(claims, "Bearer");
            identity.AddClaims(claims);
            var principal = new ClaimsPrincipal(identity);
            principal.AddIdentity(identity);            
            return principal;
        }
    }
}
