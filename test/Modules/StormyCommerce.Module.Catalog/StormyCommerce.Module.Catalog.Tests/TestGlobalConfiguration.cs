using SimplCommerce.Infrastructure.Modules;
using System.Collections.Generic;

namespace StormyCommerce.Module.Catalog.Tests
{
    //!Why this exists
    public static class TestGlobalConfiguration
    {
        public static IList<ModuleInfo> Modules { get; set; } = new List<ModuleInfo>();
        public static string ContentRootPath { get; set; }
    }
}
