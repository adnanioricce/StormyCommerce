using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.WebEncoders;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Data.Repositories;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace SimplCommerce.WebHost
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration, IHostingEnvironment hostingEnvironment, ILogger<Startup> logger) : base(configuration, hostingEnvironment, logger)
        {
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var moduleInitializers = app.ApplicationServices.GetServices<IModuleInitializer>();
            moduleInitializers.ToList().ForEach(f => f.Configure(app, env));
            app.UseMvc();
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddModules(_hostingEnvironment.ContentRootPath);
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddHttpClient();
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });
            //services.AddAntiforgery(options => options.HeaderName = "X-XSRF-Token");
            //services.AddSingleton<AutoValidateAntiforgeryTokenAuthorizationFilter, CookieOnlyAutoValidateAntiforgeryTokenAuthorizationFilter>();

            var sp = services.BuildServiceProvider();
            var moduleInitializers = sp.GetServices<IModuleInitializer>();
            foreach (var moduleInitializer in moduleInitializers)
            {
                moduleInitializer.ConfigureServices(services);
            }
            services.AddMvc();
        }
    }
}
