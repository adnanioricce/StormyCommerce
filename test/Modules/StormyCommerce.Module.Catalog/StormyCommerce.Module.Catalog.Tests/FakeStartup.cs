using System;
using SimplCommerce.WebHost;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Infraestructure.Data;

namespace StormyCommerce.Module.Catalog.Tests
{
    public class FakeStartup : Startup
    {
        
        public FakeStartup(IConfiguration configuration,IHostingEnvironment env) : base(configuration,env)
        {
            
        }
        public override void ConfigureServices(IServiceCollection services)
        {
            
        }
        public override void Configure(IApplicationBuilder app,IHostingEnvironment env)
        {
            base.Configure(app,env);
            var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using(var serviceScope = serviceScopeFactory.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<StormyDbContext>();
                if(dbContext.Database.ProviderName.ToLower().Contains("database.windows.net")){
                    throw new Exception("LIVE SETTINGS IN TESTS!");
                }

            }
        }
    }
}
