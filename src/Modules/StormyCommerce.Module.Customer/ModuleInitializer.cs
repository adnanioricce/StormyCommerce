using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Infraestructure.Data;

namespace StormyCommerce.Module.Customer
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            throw new System.NotImplementedException();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });
            //go to SimplCommerce.WebHost.Extensions.ServiceCollectionExtensions
            //serviceCollection.AddDbContext<StormyDbContext>(options =>
            //{
            //    //Add Options for your db provider
            //})
        }
    }
}
