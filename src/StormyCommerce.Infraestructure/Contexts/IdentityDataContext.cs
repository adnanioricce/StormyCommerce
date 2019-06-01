using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Models;

namespace StormyCommerce.Infraestructure.Contexts
{
    public class IdentityDataContext : IdentityDbContext<AppUser>
	{		
        public IdentityDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder); 
			new UserIdentityMap(builder.Entity<AppUser>());
		}
	}
}

