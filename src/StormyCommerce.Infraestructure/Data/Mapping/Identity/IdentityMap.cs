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
            });
        }
    }
}
