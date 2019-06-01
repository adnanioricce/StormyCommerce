using Microsoft.EntityFrameworkCore;

namespace StormyCommerce.Infraestructure.Data
{
    public interface IMappingConfiguration
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
