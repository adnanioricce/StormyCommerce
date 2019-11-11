using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.WebEncoders;
using Microsoft.IdentityModel.Logging;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Infrastructure.Web;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Infraestructure.Logging;
using StormyCommerce.Module.Customer.Data;
using SimplCommerce.Module.SampleData;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Reflection;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Authorization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using StormyCommerce.Core.Entities.Customer;

namespace SimplCommerce.WebHost
{
    public class Startup
    {
        protected readonly IHostingEnvironment _hostingEnvironment;
        protected readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment, ILogger<Startup> logger,ILoggerFactory loggerFactory)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;            
            Container.Configuration = configuration;
            Container.loggerFactory = loggerFactory;
            LogWebServerCert(logger);
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            GlobalConfiguration.WebRootPath = _hostingEnvironment.WebRootPath;
            GlobalConfiguration.ContentRootPath = _hostingEnvironment.ContentRootPath;                   
            services.AddApiVersioning(options => {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
            });            
            services.AddModules(_hostingEnvironment.ContentRootPath);
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            if(!_hostingEnvironment.IsDevelopment()){
                services.AddStormyDataStore(_configuration);
            } else {
                services.AddDbContextPool<StormyDbContext>(options => {
                    options.UseSqlite("DataSource=database.db",b => b.MigrationsAssembly("SimplCommerce.WebHost"));
                    options.EnableDetailedErrors();
                    options.EnableSensitiveDataLogging();
                });
            }
            services.AddMappings();            
            services.AddHttpClient();                        
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));
            services.AddTransient(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<HttpClient>();
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
                c.SwaggerDoc("v1", new Info { 
                    Title = "StormyCommerce API", 
                    Version = "v1",
                    Description = "a customized version of the <a href='https://github.com/simplcommerce/SimplCommerce'>SimplCommerce</a> project, build to finish a final paper project"                    
                    });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            services.AddCors(o => o.AddPolicy("Default", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();                
            }));
            if (_hostingEnvironment.IsDevelopment()) 
            { 
                services.AddMvc(x => {
                    x.Filters.Add(new AllowAnonymousFilter());
                }).AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });
            }else
            {
                services.AddMvc().AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });
            }
        }

        public virtual void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true;
                
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

            // app.UseHttpsRedirection();
            // app.UseCustomizedStaticFiles(env);
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "StormyCommerce API V1");                
                c.RoutePrefix = string.Empty;
            });

            app.UseCookiePolicy();
            app.UseCors("Default");
            app.UseMvc();            
            var moduleInitializers = app.ApplicationServices.GetServices<IModuleInitializer>();
            foreach (var moduleInitializer in moduleInitializers)
            {
                moduleInitializer.Configure(app, env);
            }
            using (var scope = app.ApplicationServices.CreateScope()){
                using (var dbContext = (StormyDbContext)scope.ServiceProvider.GetService<StormyDbContext>()){
                    if (dbContext.Database.IsSqlite())
                    {
                        if (dbContext.Database.EnsureDeleted())
                        {
                            dbContext.Database.ExecuteSqlCommand(dbContext.Database.GenerateCreateScript());
                        }
                    }                    
                    if (!dbContext.Database.IsSqlServer())
                    {
                        var userManager = scope.ServiceProvider.GetService<UserManager<StormyCustomer>>();
                        var roleManager = scope.ServiceProvider.GetService<RoleManager<ApplicationRole>>();
                        new IdentityInitializer(dbContext, userManager, roleManager).Initialize();                   
                        dbContext.SeedDbContext();
                    }
                }
            }
        }
        private void LogWebServerCert(ILogger<Startup> logger)
        {
            string defaultCertPath = _configuration.GetSection("Kestrel:Certificate:Default:Path").Value;
             logger.LogInformation($"Kestrel Default cert path: {defaultCertPath}");
            if (!string.IsNullOrEmpty(defaultCertPath))
            {
                if (File.Exists(defaultCertPath))
                {
                    logger.LogInformation("Default Cert file exists");
                }
                else
                {
                    logger.LogInformation("Default Cert file does not exists!");
                }
            }
            logger.LogInformation($"Kestrel Default cert pass:{_configuration.GetSection("Kestrel:Certificates:Default:Password")}");

            string devCertPath = _configuration.GetSection("Kestrel:Certificates:Development:Path").Value;
            logger.LogInformation($"Kestrel Development cert path:{devCertPath}");
            if (!string.IsNullOrEmpty(devCertPath))
            {
                if (File.Exists(devCertPath))
                {
                    logger.LogInformation("Development Cert file exists");
                }
                else
                {
                    logger.LogInformation("Development Cert file does NOT exists!");
                }
            }
            logger.LogInformation($"Kestrel Development cert pass: {_configuration.GetSection("Kestrel:Certificates:Development:Password")}");
            Container.Configuration = _configuration;
            logger.LogInformation("************Inside constructor logging https details*****************");
            logger.LogInformation($"Kestrel cert path:- {_configuration.GetSection("Kestrel:Certificates:Default:Path").Value}");
            if (File.Exists(_configuration.GetSection("Kestrel:Certificates:Default:Path").Value))
                logger.LogInformation("************Cert file exist:)*****************");
            else
            {
                logger.LogInformation("************Cert file don't exist:)*****************");
            }
            logger.LogInformation($"Kestrel cert path:- {_configuration.GetSection("Kestrel:Certificates:Default:Password").Value}");
        }
    }
}
