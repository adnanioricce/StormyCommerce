using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.SampleData.Data;
using SimplCommerce.Module.SampleData.Services;
using StormyCommerce.Infraestructure.Data;
using System.Data.Common;

namespace SimplCommerce.Module.SampleData
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISqlRepository, SqlRepository>();
            services.AddTransient<ISampleDataService, SampleDataService>();            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
        }
    }
}
