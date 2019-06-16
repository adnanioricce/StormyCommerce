using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace StormyCommerce.Api.Framework
{
    //!This Probably is Useless
    //!I Planned to use to Test, but I chose to put virtual methods on the Startup on WebHost
    public class Startup
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public virtual void ConfigureServices(IServiceCollection services)
        {

        }
        public virtual void Configure(IApplicationBuilder app,IHostingEnvironment env,ILoggerFactory logger)
        {

        }
    }
}