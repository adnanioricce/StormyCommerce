using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using SimplCommerce.WebHost;

namespace StormyCommerce.Modules.IntegrationTest
{
    public class CustomWebApplicationFactory : WebApplicationFactory<TestStartup>
    {             
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            //var contentRoot = Directory.GetDirectoryRoot(_relativeTargetProjectParentDir) + _relativeTargetProjectParentDir;            
            var configurationBuilder = new ConfigurationBuilder();                   
                // .AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();
            var builder = new WebHostBuilder()
                .UseContentRoot(AppDomain.CurrentDomain.BaseDirectory + @"\src\SimplCommerce.WebHost")
                .UseConfiguration(configuration)
                .UseEnvironment("Development")
                .UseStartup<Startup>();                            
            return builder;
        }                  
    }
}
