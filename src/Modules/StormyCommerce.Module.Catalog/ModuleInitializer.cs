using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Catalog.Services;

namespace StormyCommerce.Module.Catalog
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {            
            var mapper = new MapperConfiguration(mc => {
                mc.AddProfile(new CatalogProfile());
            }).CreateMapper();
            serviceCollection.AddSingleton(mapper);
            serviceCollection.AddTransient<IStormyProductService, StormyProductService>();                                                                                    
        }
    }
}