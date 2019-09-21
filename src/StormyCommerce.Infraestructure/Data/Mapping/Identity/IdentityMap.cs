using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Infraestructure.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping.Identity
{
    public class IdentityMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(e => {
                e.HasData(new ApplicationUser{
                   Id = Guid.NewGuid().ToString(),
                   UserName = "devuser",
                   SecurityStamp = DateTime.UtcNow.ToString(),
                   Email = "stormycommerce@gmail.com",
                   EmailConfirmed = true,
                   NormalizedEmail = "STORMYCOMMERCE@GMAIL.COM",
                   NormalizedUserName = "DEVUSER",                                       
                });
            });
        }
    }
}
