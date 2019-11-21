using Microsoft.EntityFrameworkCore;

namespace StormyCommerce.Infraestructure.Data
{
    public interface IStormyModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
