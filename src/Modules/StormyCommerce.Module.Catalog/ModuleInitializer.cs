using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Core.Services.Catalog;

namespace StormyCommerce.Module.Catalog
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ProductService>();
            serviceCollection.AddScoped<BrandService>();
            serviceCollection.AddScoped<CategoryService>();
            serviceCollection.AddScoped<EntityService>();
            serviceCollection.AddScoped<MediaService>();
            serviceCollection.AddScoped<ProductTemplateService>();
        }
    }
}
