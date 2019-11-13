using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PagarMe;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Api.Framework.Ioc;

namespace StormyCommerce.Module.PagarMe
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {            
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            
        }
    }
}
