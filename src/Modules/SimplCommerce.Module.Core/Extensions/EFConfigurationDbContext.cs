using Microsoft.EntityFrameworkCore;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities.Settings;

namespace SimplCommerce.Module.Core.Extensions
{
    public class EFConfigurationDbContext : DbContext
    {
        public EFConfigurationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppSettings> AppSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSettings>().ToTable("Core_AppSettings");
        }
    }
}
