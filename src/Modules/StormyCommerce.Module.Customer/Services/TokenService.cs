﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StormyCommerce.Api.Framework.Ioc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace StormyCommerce.Module.Customer.Services
{
    //Just a port from the TokenService on SimplCommerce.Module.Core
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateAccessToken(IEnumerable<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Container.Configuration["Authentication:Jwt:Key"]));

            var jwtToken = new JwtSecurityToken(
                issuer: _configuration["Authentication:Jwt:Issuer"],
                audience: "Anyone",
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(int.Parse(_configuration["Authentication:Jwt:AccessTokenDurationInMinutes"])),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        public string GenerateRefreshToken()
        {            
            var randomNumber = new byte[32];
            string token = "";
            using (var rng = RandomNumberGenerator.Create()){
                rng.GetBytes(randomNumber);
                token = Convert.ToBase64String(randomNumber);
            }
            return token.Replace("+",string.Empty)
                .Replace("=",string.Empty)
                .Replace("/",string.Empty);
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = true,
                ValidIssuer = _configuration["Authentication:Jwt:Issuer"],
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:Jwt:Key"])),
                ValidateLifetime = false //in this case, we don't care about the token's expiration date
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            if (!(securityToken is JwtSecurityToken jwtSecurityToken) || !string.Equals(jwtSecurityToken.Header.Alg, SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }

            return principal;
        }
    }
}
