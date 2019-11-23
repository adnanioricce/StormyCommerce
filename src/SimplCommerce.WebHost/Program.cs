using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using StormyCommerce.Infraestructure.Extensions;
using System;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
namespace SimplCommerce.WebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            try
            {
                var host = CreateWebHostBuilder(args).Build();
                host.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        // Changed to BuildWebHost2 to make EF don't pickup during design time
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            Microsoft.AspNetCore.WebHost.CreateDefaultBuilder(args)             
                .UseStartup<Startup>()
                .UseKestrel()                
                .ConfigureAppConfiguration(SetupConfiguration)
                .ConfigureLogging(SetupLogging);
                
        private static void SetupConfiguration(WebHostBuilderContext hostingContext, IConfigurationBuilder configBuilder)
        {

            var env = hostingContext.HostingEnvironment;
            configBuilder.AddJsonFile("appsettings.json",optional:false,reloadOnChange:false);
            if(env.IsDevelopment()){
                var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
                if (appAssembly != null)
                {
                    configBuilder.AddUserSecrets(appAssembly, optional: true);
                }
            }
            configBuilder.AddEnvironmentVariables();
            var configuration = new ConfigurationBuilder().Build();
            
            configBuilder.AddEntityFrameworkConfig(options => {
                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
                if (!env.IsDevelopment())
                {
                    options.UseSqlServer(configuration.GetConnectionString("DevConnection"), b => b.MigrationsAssembly("SimplCommerce.WebHost"));                    
                }
                else
                {                    
                    options.UseSqlite("DataSource=config.db", b => b.MigrationsAssembly("SimplCommerce.WebHost"));                                       
                }

            });
            Log.Logger = new LoggerConfiguration()
                       .ReadFrom.Configuration(configuration)                       
                       .CreateLogger();
        }

        private static void SetupLogging(WebHostBuilderContext hostingContext, ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddSerilog();
            loggingBuilder.AddConsole();
            loggingBuilder.AddDebug();
            loggingBuilder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
        }        
    }
}
