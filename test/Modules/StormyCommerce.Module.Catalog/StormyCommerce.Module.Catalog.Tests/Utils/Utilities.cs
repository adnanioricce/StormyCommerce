using System;
using StormyCommerce.Infraestructure.Data;
namespace StormyCommerce.Module.Catalog.Tests.Utils
{
    public static class Utilities
    {
        public static void InitializeTestDb(StormyDbContext context)
        {
            StormyDbContextInitializer.Initialize(context);
        }
    }
}
