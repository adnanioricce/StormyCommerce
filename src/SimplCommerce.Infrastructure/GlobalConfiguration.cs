using SimplCommerce.Infrastructure.Localization;
using SimplCommerce.Infrastructure.Modules;
using System.Collections.Generic;

namespace SimplCommerce.Infrastructure
{
    //need a better way to do this...
    public static class GlobalConfiguration
    {
        public static IList<ModuleInfo> Modules { get; set; } = new List<ModuleInfo>();

        public static IList<Culture> Cultures { get; set; } = new List<Culture>();

        public static string DefaultCulture => "en-US";

        public static string WebRootPath { get; set; }

        public static string ContentRootPath { get; set; }
    }
}
