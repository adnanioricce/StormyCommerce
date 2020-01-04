using Microsoft.EntityFrameworkCore;

namespace StormyCommerce.Infraestructure.Data.Mapping.Address
{
    public class AddressMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Core.Entities.Address.Address>((entity =>
            {
                entity.OwnsOne((prop => prop.Detail),a => {
                    a.Property(prop => prop.AddressLine1).HasMaxLength(450);
                    a.Property(prop => prop.AddressLine2).HasMaxLength(450);
                    a.Property(prop => prop.City).HasMaxLength(450);
                    a.Property(prop => prop.CountryCode).HasMaxLength(4);
                    a.Property(prop => prop.DistrictName).HasMaxLength(450);
                    a.Property(prop => prop.Number).HasMaxLength(16);
                    a.Property(prop => prop.ZipCode).HasMaxLength(64);
                    a.Property(prop => prop.State).HasMaxLength(450);
                    a.Property(prop => prop.Complement).HasMaxLength(450);
                    a.OwnsOne(prop => prop.Phone,b => {
                        b.Property(prop => prop.DD).HasMaxLength(2);
                        b.Property(prop => prop.DDI).HasMaxLength(2);
                        b.Property(prop => prop.Number).HasMaxLength(11);
                        b.Property(prop => prop.FullNumber).HasMaxLength(15);
                    });                                        
                });                
                entity.Property(prop => prop.ContactName).HasMaxLength(450);                
            }));
        }
    }
}
