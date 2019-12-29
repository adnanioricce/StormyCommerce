using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Tax;

namespace StormyCommerce.Infraestructure.Data.Mapping.Tax
{
    public class TaxClassMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaxClass>(entity =>
            {
                entity.ToTable("Tax_TaxClass");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);
            });
        }
    }
}
