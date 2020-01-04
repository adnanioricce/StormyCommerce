using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Settings;

namespace StormyCommerce.Infraestructure.Data.Mapping.Shipments
{
    public class AppSettingsMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSettings>().ToTable("config_appsettings");
            
        }
    }
}
