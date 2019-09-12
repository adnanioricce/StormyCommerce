using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using StormyCommerce.Infraestructure.Extensions;
using System;
using System.Net;

namespace SimplCommerce.WebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            try
            {
                BuildWebHost2(args).Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        // Changed to BuildWebHost2 to make EF don't pickup during design time
        private static IWebHost BuildWebHost2(string[] args) =>
            Microsoft.AspNetCore.WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options =>
                {
                    var configuration = (IConfiguration)options.ApplicationServices.GetService(typeof(IConfiguration));
                    var httpPort = configuration.GetValue("ASPNETCORE_HTTP_PORT", 80);
                    var httpsPort = configuration.GetValue("ASPNETCORE_HTTPS_PORT", 443);
                    var certPassword = configuration.GetValue<string>("Kestrel:Certificates:Development:Password");
                    var certPath = configuration.GetValue<string>("Kestrel:Certificates:Development:Path");
                    Console.WriteLine($"{nameof(httpsPort)}: {httpsPort}");
                    Console.WriteLine($"{nameof(certPassword)}: {certPassword}");
                    Console.WriteLine($"{nameof(certPath)}: {certPath}");
                    options.Listen(IPAddress.Any, httpPort);
                    options.Listen(IPAddress.Any, httpsPort, listerOptions =>
                    {
                        listerOptions.UseHttps(certPath, certPassword);
                    });
                })
                .UseStartup<Startup>()
                .ConfigureAppConfiguration(SetupConfiguration)
                .ConfigureLogging(SetupLogging)
                .Build();

        private static void SetupConfiguration(WebHostBuilderContext hostingContext, IConfigurationBuilder configBuilder)
        {
            var env = hostingContext.HostingEnvironment;
            var configuration = configBuilder.Build();
            configBuilder.AddEntityFrameworkConfig(options =>
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            );
            Log.Logger = new LoggerConfiguration()
                       .ReadFrom.Configuration(configuration)
                       .CreateLogger();
        }

        private static void SetupLogging(WebHostBuilderContext hostingContext, ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddSerilog();
        }
    }
}
