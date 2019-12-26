using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Address;

namespace StormyCommerce.Infraestructure.Data.Mapping.Address
{
    public class CountryMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Country>(entity => {
                entity.ToTable("Core_Country");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(450);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);
            });
        }
    }
}
