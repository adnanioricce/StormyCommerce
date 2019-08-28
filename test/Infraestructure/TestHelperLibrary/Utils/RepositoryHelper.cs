using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data.Repositories;

namespace TestHelperLibrary.Utils
{
    public static class RepositoryHelper
    {
        public static StormyRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new StormyRepository<T>(DbContextHelper.GetDbContext());
        }
    }
}
