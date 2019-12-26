using Microsoft.EntityFrameworkCore;

namespace StormyCommerce.Infraestructure.Data.Mapping.Address
{
    public class AddressMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Core.Entities.Address.Address>((System.Action<Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Core.Entities.Address.Address>>)(entity =>
            {
                entity.OwnsOne((System.Linq.Expressions.Expression<System.Func<Core.Entities.Address.Address, Core.Entities.Common.AddressDetail>>)(prop => (Core.Entities.Common.AddressDetail)prop.Detail),a => {
                    a.Property(prop => prop.AddressLine1).HasMaxLength(450);
                    a.Property(prop => prop.AddressLine2).HasMaxLength(450);
                    a.Property(prop => prop.City).HasMaxLength(450);
                    a.Property(prop => prop.CountryCode).HasMaxLength(4);
                    a.Property(prop => prop.DistrictName).HasMaxLength(450);
                    a.Property(prop => prop.Number).HasMaxLength(16);
                    a.Property(prop => prop.ZipCode).HasMaxLength(64);
                    a.Property(prop => prop.State).HasMaxLength(450);
                    a.Property(prop => prop.Complement).HasMaxLength(450);                                        
                });                
                entity.Property(prop => prop.ContactName).HasMaxLength(450);
                entity.Property(prop => prop.Phone).HasMaxLength(450);                

            }));
        }
    }
}
