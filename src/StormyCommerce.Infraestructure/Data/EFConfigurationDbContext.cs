using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Settings;

namespace StormyCommerce.Infraestructure.Data
{
    public class EFConfigurationDbContext : DbContext
    {
        public EFConfigurationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppSetting> AppSettings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.Property(prop => prop.Value).HasMaxLength(450).IsRequired();
                entity.Property(prop => prop.Module).HasMaxLength(450).IsRequired();
            });            
        }
    }
}
