using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StormyCommerce.Infraestructure.Entities;

namespace StormyCommerce.Infraestructure.Models
{
	public class UserIdentityMap
	{
		public UserIdentityMap(EntityTypeBuilder<AppUser> entityBuilder)
		{
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.UserName).IsRequired(); 
			entityBuilder.Property(t => t.Email).IsRequired(); 
		}
	}
}
