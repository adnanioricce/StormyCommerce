using StormyCommerce.Infraestructure.Entities;
using System.Collections.Generic;

namespace TestHelperLibrary.Utils
{
    public static class UserSeeder
    {
        public static readonly System.Guid ValidSampleUserGuid = System.Guid.NewGuid();
        public static List<ApplicationUser> ValidApplicationUserListSeed()
        {
            return new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Email = "sample@email.com",
                    UserName = "adnanioricce",
                    NormalizedEmail = "SAMPLE@EMAIL.COM",
                    EmailConfirmed = true,                   
                },
                new ApplicationUser
                {
                    Email = "asimple@email.com",
                    UserName = "oni",
                    NormalizedEmail = "ASIMPLE@EMAIL.COM",
                    EmailConfirmed = true,
                }
            };
        }
        public static Dictionary<ApplicationUser,string> ValidCreateUserSeed()
        {
            Dictionary<ApplicationUser, string> dictionary = new Dictionary<ApplicationUser, string>();
            dictionary.Add(new ApplicationUser
            {
                UserName = "adnanioricce"
            },"Ty22f@7#32!");
            return dictionary; 
        }
    }
}
