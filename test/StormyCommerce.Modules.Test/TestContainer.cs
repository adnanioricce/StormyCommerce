using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace StormyCommerce.Modules.IntegrationTest
{
    public static class TestContainer
    {
        public static IConfiguration Configuration { get; set; }
        public static IHostingEnvironment HostingEnvironment { get; set; }
    }
}
