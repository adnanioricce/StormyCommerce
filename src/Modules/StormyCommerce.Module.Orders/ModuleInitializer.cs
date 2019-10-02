using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Services;

namespace StormyCommerce.Module.Orders
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICalcPrecoPrazoWSSoap,CalcPrecoPrazoWSSoapClient>();
            serviceCollection.AddTransient<CorreiosService>();
            
        }
    }
}
