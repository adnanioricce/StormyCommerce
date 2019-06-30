using System;
using SimplCommerce.WebHost;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Infraestructure.Data;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Core.Interfaces;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Infraestructure.Data.Repositories;
using System.Collections.Generic;

namespace StormyCommerce.Module.Catalog.Tests
{
    public class FakeStartup : Startup
    {
        private const string MODULE_ID = "StormyCommerce.Module.Catalog";
        
        public FakeStartup(IConfiguration configuration,IHostingEnvironment env) : base(configuration,env)
        {
            
        }        
        public override void ConfigureServices(IServiceCollection services)
        {            
            services.AddSingleModule(_hostingEnvironment.ContentRootPath, MODULE_ID);
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));
            //this probably will fail
            services.AddCustomizedMvc(new List<ModuleInfo>
            {
                new ModuleConfigurationManager().GetSingleModule(MODULE_ID)
            });
            var sp = services.BuildServiceProvider();
            var moduleInitializers = sp.GetServices<IModuleInitializer>();
            foreach (var moduleInitializer in moduleInitializers)
            {
                moduleInitializer.ConfigureServices(services);
            }
        }
        public override void Configure(IApplicationBuilder app,IHostingEnvironment env)
        {
            base.Configure(app,env);
            var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using(var serviceScope = serviceScopeFactory.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<StormyDbContext>();
                if(dbContext.Database.ProviderName.ToLower().Contains("database.windows.net"))
                {
                    throw new Exception("LIVE SETTINGS IN TESTS!");
                }
            }
        }
    }
}
