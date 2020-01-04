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
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Reflection;
using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Filters;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Core.Entities;
using SimplCommerce.Module.Localization.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SimplCommerce.Module.Localization.TagHelpers;
using MediatR;

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
            services.AddCustomizedIdentity(_configuration);            
            services.AddStormyDataStore(_configuration);
            services.AddApiVersioning(options => {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 5);
            });            
            services.AddModules(_hostingEnvironment.ContentRootPath);
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });            
                                 
            services.AddMappings();            
            services.AddHttpClient();                        
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));
            services.AddTransient(typeof(IAppLogger<>), typeof(LoggerAdapter<>));            
            services.Configure<RazorViewEngineOptions>(
                options => { options.ViewLocationExpanders.Add(new ThemeableViewLocationExpander()); });
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });
            services.AddScoped<ITagHelperComponent, LanguageDirectionTagHelperComponent>();
            services.AddTransient<IRazorViewRenderer, RazorViewRenderer>();            
            services.AddAntiforgery(options => options.HeaderName = "X-XSRF-Token");
            services.AddSingleton<AutoValidateAntiforgeryTokenAuthorizationFilter, CookieOnlyAutoValidateAntiforgeryTokenAuthorizationFilter>();
            services.AddCloudscribePagination();
            services.AddCustomizedLocalization();
            services.AddCustomizedMvc(GlobalConfiguration.Modules);
            services.AddScoped<ServiceFactory>(p => p.GetService);
            services.AddScoped<IMediator, Mediator>();
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
                var security = new Dictionary<string, IEnumerable<string>>
                {
                    {"Bearer", new string[] { }},
                };
                c.AddSecurityDefinition(Roles.Customer
                    , new ApiKeyScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
                c.AddSecurityRequirement(security);
            });
            services.AddCors(o => o.AddPolicy("Default", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();   
                builder.AllowCredentials();             
            }));                   
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });        
            services.AddMemoryCache();
            services.AddHealthChecks();
        }

        public virtual void Configure(IApplicationBuilder app, IHostingEnvironment env,IAppLogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                IdentityModelEventSource.ShowPII = true;
                app.AddEfDiagrams<StormyDbContext>();
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
            app.UseHealthChecks("/check");
            app.UseCustomizedHttpsConfiguration();            
            // app.UseStaticFiles();            
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "StormyCommerce API V1");                
                c.RoutePrefix = "api";
            });
            app.UseCustomizedStaticFiles(env);
            app.UseCookiePolicy();
            app.UseCors(builder => {                
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                builder.AllowAnyOrigin();
                builder.AllowCredentials();                                
            });            
            app.UseCustomizedIdentity();
            // app.UseCustomizedRequestLocalization();
            app.UseCustomizedMvc();
            app.UseMvc();            
            var moduleInitializers = app.ApplicationServices.GetServices<IModuleInitializer>();
            foreach (var moduleInitializer in moduleInitializers)
            {
                moduleInitializer.Configure(app, env);
            }
            BuildDb(app,logger);
            
        }
        private void BuildDb(IApplicationBuilder app,IAppLogger<Startup> logger)
        {
            if(!this._hostingEnvironment.IsDevelopment()) return;            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                using (var dbContext = (StormyDbContext)scope.ServiceProvider.GetService<StormyDbContext>())
                {
                    if ((dbContext.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists() && !dbContext.Database.IsSqlite())
                    {
                        try
                        {
                            dbContext.Database.Migrate();
                        }
                        catch (Exception ex)
                        {
                            logger.LogError("Error on database migration", ex.Message);
                            logger.LogInformation("exception throwed", ex);
                            logger.LogStackTrace("Stacktrace:", ex.StackTrace);
                        }
                    }

                    if (dbContext.Database.IsSqlite())
                    {
                        dbContext.Database.EnsureDeleted();
                        var result = dbContext.Database.ExecuteSqlCommand(dbContext.Database.GenerateCreateScript());
                        dbContext.SeedDbContext();
                        var userManager = scope.ServiceProvider.GetService<UserManager<User>>();
                        var roleManager = scope.ServiceProvider.GetService<RoleManager<Role>>();
                        new IdentityInitializer(dbContext, userManager, roleManager).Initialize();
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
