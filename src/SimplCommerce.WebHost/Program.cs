using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using StormyCommerce.Infraestructure.Extensions;
using System;
using System.Net;
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
                .UseKestrel((context,options) =>
                {
                    options.Limits.MaxConcurrentConnections = 100;
                    options.Limits.MaxConcurrentUpgradedConnections = 100;
                    options.Limits.MaxRequestBodySize = 10 * 1024;
                    options.Limits.MinRequestBodyDataRate =
                        new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                    options.Limits.MinResponseDataRate =
                        new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                    var configuration = (IConfiguration)options.ApplicationServices.GetService(typeof(IConfiguration));
                    var httpPort = configuration.GetValue("ASPNETCORE_HTTP_PORT", 49208);
                    var httpsPort = configuration.GetValue("ASPNETCORE_HTTPS_PORT", 49206);
                    var certPassword = configuration.GetValue<string>("Kestrel:Certificates:Development:Password");
                    var certPath = configuration.GetValue<string>("Kestrel:Certificates:Development:Path");
                    Console.WriteLine($"{nameof(httpsPort)}: {httpsPort}");
                    Console.WriteLine($"{nameof(certPassword)}: {certPassword}");
                    Console.WriteLine($"{nameof(certPath)}: {certPath}");
                    options.ConfigureHttpsDefaults(listenOptions =>
                    {
                        //TODO:Change to a production https certificate
                        listenOptions.ServerCertificate = new X509Certificate2(certPath,certPassword);
                    });
                    options.Listen(IPAddress.Loopback, httpPort);
                    options.Listen(IPAddress.Loopback, httpsPort, listerOptions =>
                    {                
                        listerOptions.UseHttps(certPath, certPassword);
                    });
                    options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(2);
                    options.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(1);
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
                    options.UseInMemoryDatabase("InMemoryStormyDb")
                    // options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            );
            Log.Logger = new LoggerConfiguration()
                       .ReadFrom.Configuration(configuration)
                       .CreateLogger();
        }

        private static void SetupLogging(WebHostBuilderContext hostingContext, ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddSerilog();
        }
        private static void ConfigureWebServer(WebHostBuilderContext context,KestrelServerOptions options)
        {
            options.Limits.MaxConcurrentConnections = 100;
            options.Limits.MaxConcurrentUpgradedConnections = 100;
            options.Limits.MaxRequestBodySize = 10 * 1024;
            options.Limits.MinRequestBodyDataRate =
                new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
            options.Limits.MinResponseDataRate =
                new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
            var configuration = (IConfiguration)options.ApplicationServices.GetService(typeof(IConfiguration));
            var httpPort = configuration.GetValue("ASPNETCORE_HTTP_PORT", 80);
            var httpsPort = configuration.GetValue("ASPNETCORE_HTTPS_PORT", 443);
            var certPassword = configuration.GetValue<string>("Kestrel:Certificates:Development:Password");
            var certPath = configuration.GetValue<string>("Kestrel:Certificates:Development:Path");
            Console.WriteLine($"{nameof(httpsPort)}: {httpsPort}");
            Console.WriteLine($"{nameof(certPassword)}: {certPassword}");
            Console.WriteLine($"{nameof(certPath)}: {certPath}");
            options.ConfigureHttpsDefaults(listenOptions =>
            {
                //TODO:Change to a production https certificate
                listenOptions.ServerCertificate = new X509Certificate2(certPath,certPassword);
            });
            options.Listen(IPAddress.Loopback, httpPort);
            options.Listen(IPAddress.Loopback, httpsPort, listerOptions =>
            {                
                listerOptions.UseHttps(certPath, certPassword);
            });
            options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(2);
            options.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(1);
        }
    }
}
