
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.PagarMe.Services;
using SimplCommerce.Module.Payments.Interfaces;

namespace SimplCommerce.Module.PagarMe
{
    public class PagarMeModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {            
            serviceCollection.AddTransient<IPaymentProvider, PagarMeProcessor>();            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
        }
    }
}
