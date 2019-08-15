namespace StormyCommerce.Core.Tests.Helpers
{
    public static class RepositoryHelper
    {
        public static StormyRepository<T> GetRepository<T>() where T : class
        {
            return new StormyRepository<T>(DbContextHelper.GetDbContext());
        }
    }
}