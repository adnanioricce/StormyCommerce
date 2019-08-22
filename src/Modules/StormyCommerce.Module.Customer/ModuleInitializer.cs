using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.Core.Services;
using SimplCommerce.Module.EmailSenderSendgrid;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Services;

namespace StormyCommerce.Module.Customer
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
	        serviceCollection.AddTransient<ITokenService,TokenService>();
	        serviceCollection.AddTransient<IEmailSender,EmailSender>();
	        serviceCollection.AddScoped<IUserIdentityService,UserIdentityService>();
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
