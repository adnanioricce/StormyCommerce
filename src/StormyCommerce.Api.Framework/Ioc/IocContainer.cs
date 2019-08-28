using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace StormyCommerce.Api.Framework.Ioc
{
    public static class Container
    {
        public static ServiceProvider Provider { get; set; }
        public static IConfiguration Configuration { get; set; }
    }
}