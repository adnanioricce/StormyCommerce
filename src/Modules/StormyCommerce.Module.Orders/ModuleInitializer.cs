using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PagarMe;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.Shipments.Interfaces;
using SimplCommerce.Module.Shipments.Services;
using StormyCommerce.Api.Framework.Ioc;
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
            serviceCollection.AddTransient<IShippingService, ShippingService>();
            serviceCollection.AddTransient<IShippingBuilder, ShippingBuilder>();
            serviceCollection.AddTransient<IOrderService, OrderService>();            
            serviceCollection.AddTransient<IShippingProvider,CorreiosService>();                        
        }
    }
}
