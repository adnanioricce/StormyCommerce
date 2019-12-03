using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PagarMe;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Payments;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Services.Orders;
using StormyCommerce.Core.Services.Shipping;
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
            serviceCollection.AddTransient<IPaymentProcessor, PaymentProcessor>();                    
            PagarMeService.DefaultApiKey = Container.Configuration["PagarMe:ApiKey"];
            PagarMeService.DefaultEncryptionKey = Container.Configuration["PagarMe:EncryptionKey"];            
            var pagarme = new PagarMeService(PagarMeService.DefaultApiKey,PagarMeService.DefaultEncryptionKey);                        
            serviceCollection.AddSingleton(pagarme);
            serviceCollection.AddSingleton<PagarMeWrapper>();
            
        }
    }
}
