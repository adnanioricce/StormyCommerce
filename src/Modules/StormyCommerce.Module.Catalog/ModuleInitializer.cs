using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;

using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Module.Catalog.Services;

namespace StormyCommerce.Module.Catalog
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductService, ProductService>();
            serviceCollection.AddScoped<IBrandService, BrandService>();
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<IEntityService, EntityService>();
            serviceCollection.AddScoped<IMediaService, MediaService>();
            serviceCollection.AddScoped<IProductTemplateService, ProductTemplateService>();            
            serviceCollection.AddTransient<IBrandService, BrandService>();
            serviceCollection.AddTransient<IMediaService, MediaService>();
            serviceCollection.AddTransient<IStorageService, BlobStorage>();
        }
    }
}
