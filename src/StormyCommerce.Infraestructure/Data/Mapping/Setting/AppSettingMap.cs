using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Settings;

namespace StormyCommerce.Infraestructure.Data.Mapping.Setting
{
    public class AppSettingMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.HasKey(prop => prop.Id);
                entity.Property(prop => prop.Module).HasMaxLength(450);
                entity.Property(prop => prop.Value).HasMaxLength(450);
            });
        }
    }
}
