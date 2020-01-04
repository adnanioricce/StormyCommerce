
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PagarMe;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Module.Orders.Services;

namespace SimplCommerce.Module.PagarMe
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {            
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {            
            PagarMeService.DefaultApiKey = Container.Configuration["PagarMe:ApiKey"];
            PagarMeService.DefaultEncryptionKey = Container.Configuration["PagarMe:EncryptionKey"];
            var pagarme = new PagarMeService(PagarMeService.DefaultApiKey, PagarMeService.DefaultEncryptionKey);
            serviceCollection.AddSingleton(pagarme);
            serviceCollection.AddSingleton<PagarMeWrapper>();
        }
    }
}
