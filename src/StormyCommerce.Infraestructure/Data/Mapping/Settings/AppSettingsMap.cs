using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Settings;
using StormyCommerce.Core.Entities.Shipping;
using System;

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
