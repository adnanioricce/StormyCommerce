using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using System.Collections.Generic;

namespace TestHelperLibrary.Utils
{
    public static class RepositoryHelper
    {
        public static StormyRepository<T> GetRepository<T>() where T : EntityBase
        {
            return new StormyRepository<T>(DbContextHelper.GetDbContext());
        }

        public static StormyRepository<T> GetRepository<T>(StormyDbContext context) where T : EntityBase
        {
            return new StormyRepository<T>(context);
        }

        public static StormyRepository<T> GetRepository<T>(StormyDbContext context, List<T> seed = null) where T : EntityBase
        {
            if (seed == null)
                return GetRepository<T>(context);

            context.AddRange(seed);
            context.SaveChanges();
            return GetRepository<T>(context);
        }
    }
}
