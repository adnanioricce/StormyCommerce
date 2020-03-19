using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.Correios.Interfaces;
using SimplCommerce.Module.Correios.Services;
using SimplCommerce.Module.Shipments.Services;

namespace SimplCommerce.Module.Correios
{
    public class CorreiosModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICalcPrecoPrazoWSSoap, CalcPrecoPrazoWSSoapClient>();
            serviceCollection.AddTransient<CorreiosService>();            
            serviceCollection.AddTransient<IPackageBuilder,PackageBuilder>();
            serviceCollection.AddTransient<IFreightCalculator,CorreiosFreightCalculator>();
        }
    }
}
