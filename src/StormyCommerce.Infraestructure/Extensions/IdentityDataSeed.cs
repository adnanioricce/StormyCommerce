using Bogus;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Infraestructure.Extensions
{
    public static class IdentityDataSeed
    {
        public static List<User> ApplicationUserSeed(int count = 1, bool withDefinedPassword = true)
        {
            var fakeAppUser = new Faker<User>("pt_BR")
                .RuleFor(v => v.UserGuid, f => new Guid(f.Hashids.Encode(f.Random.Int(1, 32))))
                .RuleFor(v => v.FullName,f => f.Person.FullName)
                .RuleFor(v => v.CPF, f => f.Random.Utf16String(11, 11))
                .RuleFor(v => v.Email, f => f.Internet.Email())
                .RuleFor(v => v.UserName, f => f.Person.UserName)
                .RuleFor(v => v.PasswordHash, f => withDefinedPassword ? "Ty22f@7#32!" : f.Internet.Password().HashPassword())
                .RuleFor(v => v.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(v => v.EmailConfirmed, true)
                .RuleFor(v => v.TwoFactorEnabled, false)
                .RuleFor(v => v.SecurityStamp, Guid.NewGuid().ToString())
                .RuleFor(v => v.LockoutEnabled, false)
                .RuleFor(v => v.LockoutEnd, DateTime.UtcNow);
            return fakeAppUser.Generate(count);
        }        
    }
}
