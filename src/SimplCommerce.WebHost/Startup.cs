using System.Text.Encodings.Web;
using System.Text.Unicode;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.WebEncoders;
using Swashbuckle.AspNetCore.Swagger;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Infrastructure.Web;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Data.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Module.Customer.Data;
using Serilog;
using Microsoft.Extensions.Logging;
using System.IO;

namespace SimplCommerce.WebHost
{
    public class Startup
    {
        protected readonly IHostingEnvironment _hostingEnvironment;
        protected readonly IConfiguration _configuration;
        private string _moviesApiKey = null;

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment,ILogger<Startup> logger)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            Container.Configuration = configuration;            
            string defaultCertPath = configuration.GetSection("Kestrel:Certificate:Default:Path").Value;            
            logger.LogInformation($"Kestrel Default cert path: {defaultCertPath}");
            if(!string.IsNullOrEmpty(defaultCertPath)){
                if(File.Exists(defaultCertPath)){
                    logger.LogInformation("Default Cert file exists");
                } else{
                    logger.LogInformation("Default Cert file does not exists!");
                }
            }
            logger.LogInformation($"Kestrel Default cert pass:{_configuration.GetSection("Kestrel:Certificates:Default:Password")}");

            string devCertPath = configuration.GetSection("Kestrel:Certificates:Development:Path").Value;
            logger.LogInformation($"Kestrel Development cert path:{devCertPath}");
            if(!string.IsNullOrEmpty(devCertPath)){
                if(File.Exists(devCertPath)){
                    logger.LogInformation("Development Cert file exists");
                } else {
                    logger.LogInformation("Development Cert file does NOT exists!");
                }
            }
            logger.LogInformation($"Kestrel Development cert pass: {_configuration.GetSection("Kestrel:Certificates:Development:Password")}");
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            GlobalConfiguration.WebRootPath = _hostingEnvironment.WebRootPath;
            GlobalConfiguration.ContentRootPath = _hostingEnvironment.ContentRootPath;            
            services.AddModules(_hostingEnvironment.ContentRootPath);

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddStormyDataStore(_configuration);
            //services.AddCustomizedIdentity(_configuration);
            services.AddHttpClient();
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));            
            
            services.Configure<RazorViewEngineOptions>(
                options => { options.ViewLocationExpanders.Add(new ThemeableViewLocationExpander()); });
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });            
            services.AddAntiforgery(options => options.HeaderName = "X-XSRF-Token");
            services.AddSingleton<AutoValidateAntiforgeryTokenAuthorizationFilter, CookieOnlyAutoValidateAntiforgeryTokenAuthorizationFilter>();
            services.AddCloudscribePagination();

            var sp = services.BuildServiceProvider();
            var moduleInitializers = sp.GetServices<IModuleInitializer>();
            foreach (var moduleInitializer in moduleInitializers)
            {
                moduleInitializer.ConfigureServices(services);
            }
                      
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "StormyCommerce API", Version = "v1" });
            });
            services.AddCors(o => o.AddPolicy("Default", builder => {
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));
            services.AddMvc();
            
        }

        public virtual void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {                   
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseWhen(
                    context => !context.Request.Path.StartsWithSegments("/api"),
                    a => a.UseExceptionHandler("/Home/Error")
                );
                app.UseHsts();
            }

            app.UseWhen(
                context => !context.Request.Path.StartsWithSegments("/api"),
                a => a.UseStatusCodePagesWithReExecute("/Home/ErrorWithCode/{0}")
            );

            app.UseHttpsRedirection();
            app.UseCustomizedStaticFiles(env);
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "StormyCommerce API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCookiePolicy();           
            app.UseCors(options =>
            {
                options.WithOrigins("https://localhost:49206", "http://localhost:49208", "http://localhost:49209", "https://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
            app.UseMvc();
            
            

            var moduleInitializers = app.ApplicationServices.GetServices<IModuleInitializer>();
            foreach (var moduleInitializer in moduleInitializers)
            {
                moduleInitializer.Configure(app, env);
            }                        
        }
        
    }
}
