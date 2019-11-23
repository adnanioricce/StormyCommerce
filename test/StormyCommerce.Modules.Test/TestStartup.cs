using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.WebEncoders;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.SampleData;
using SimplCommerce.WebHost;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Module.Customer.Data;

namespace StormyCommerce.Modules.IntegrationTest
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration, IHostingEnvironment hostingEnvironment, ILogger<Startup> logger,ILoggerFactory loggerFactory) : base(configuration, hostingEnvironment, logger,loggerFactory)
        {
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var moduleInitializers = app.ApplicationServices.GetServices<IModuleInitializer>();
            moduleInitializers.ToList().ForEach(f => f.Configure(app, env));
            app.UseMvc();
            using (var scope = app.ApplicationServices.CreateScope()){
                using (var dbContext = (StormyDbContext)scope.ServiceProvider.GetService<StormyDbContext>()){
                    if (dbContext.Database.IsSqlite())
                    {
                        if (dbContext.Database.EnsureDeleted())
                        {                            
                            dbContext.Database.ExecuteSqlCommand(dbContext.Database.GenerateCreateScript());
                        }
                    }
                    var userManager = (UserManager<StormyCustomer>)scope.ServiceProvider.GetService<UserManager<StormyCustomer>>();
                    var roleManager = (RoleManager<ApplicationRole>)scope.ServiceProvider.GetService<RoleManager<ApplicationRole>>();
                    new IdentityInitializer(dbContext, userManager, roleManager).Initialize();                    
                    dbContext.SeedDbContext();                    
                }
            }
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlite()
            .AddDbContext<IStormyDbContext,StormyDbContext>(
                contextOptions => contextOptions.UseSqlite("endpointDb.db",
                builder => builder.MigrationsAssembly(typeof(TestStartup).GetTypeInfo().Assembly.GetName().Name))
                );            
            services.AddModules(AppContext.BaseDirectory + @"\src\SimplCommerce.WebHost");
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
