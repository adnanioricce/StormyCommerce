using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Api.Framework.Ioc
{
    public static class Container
    {
        public static ServiceProvider Provider { get; set; }
        public static IConfiguration Configuration { get; set; }
        public static CustomerAddress OriginAddress { get; private set; } = new CustomerAddress();
    }
}