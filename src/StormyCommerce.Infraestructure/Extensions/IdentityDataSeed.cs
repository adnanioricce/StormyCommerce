using Bogus;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Entities;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Infraestructure.Extensions
{
    public static class IdentityDataSeed
    {
        public static List<ApplicationUser> ApplicationUserSeed(int count = 1, bool withDefinedPassword = true)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var fakeAppUser = new Faker<ApplicationUser>("pt_BR")
                .RuleFor(v => v.Id, f => f.Hashids.Encode(f.Random.Int(1, 32)))
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

        public static List<StormyCustomer> StormyCustomerSeed(int count = 1)
        {
            var appUsers = ApplicationUserSeed(count);
            var fakeCustomer = new Faker<StormyCustomer>("pt_BR")
                .RuleFor(v => v.IsDeleted, false)
                .RuleFor(v => v.CreatedOn, f => f.Date.Recent(10))
                .RuleFor(v => v.Email, f => appUsers[f.IndexVariable].Email)
                .RuleFor(v => v.FullName, f => f.Person.FullName)
                .RuleFor(v => v.UserId, f => appUsers[f.IndexVariable].Id.ToString())
                .RuleFor(v => v.UserName, f => appUsers[f.IndexVariable].UserName)
                .RuleFor(v => v.CPF, f => f.Random.Utf16String(11, 11));
            return fakeCustomer.Generate(count);
        }
    }
}
