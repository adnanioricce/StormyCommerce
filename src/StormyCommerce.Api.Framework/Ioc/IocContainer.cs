using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Core.Entities.Common;
namespace StormyCommerce.Api.Framework.Ioc
{
    public static class Container
    {
        public static ServiceProvider Provider { get; set; }
        public static IConfiguration Configuration { get; set; }
        public static Address OriginAddress { get; private set; } = new Address();
    }
}