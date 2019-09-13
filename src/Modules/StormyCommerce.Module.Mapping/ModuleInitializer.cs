using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Module.Mapping.Mappings;

namespace StormyCommerce.Module.Mapping
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            var mapConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CatalogProfile());
                mc.AddProfile(new CustomerProfile());
                mc.AddProfile(new PagarMeMapping());
            });
            IMapper mapper = mapConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }
    }
}
