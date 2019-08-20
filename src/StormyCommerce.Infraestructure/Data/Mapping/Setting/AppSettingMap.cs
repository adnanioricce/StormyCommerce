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
                //entity.Property(prop => prop.)
            });
        }
    }
}
