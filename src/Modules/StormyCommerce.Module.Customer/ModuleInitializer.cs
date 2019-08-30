using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SimplCommerce.Infrastructure.Modules;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Data;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Services;
namespace StormyCommerce.Module.Customer
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            // if(env.IsDevelopment())
            // {
            //     app.Use(async (httpContext,next) => {
            //         var user = context.User.Identity.Name;
            //         DeveloperLogin(context).Wait();
            //         await next.Invoke();
            //     });
            //     app.UseDeveloperExceptionPage();
            //     app.UseDatabaseErrorPage();
            // }
            // var context = (StormyDbContext)app.ApplicationServices.GetService(typeof(StormyDbContext));
            // var userManager = (UserManager<ApplicationUser>)app.ApplicationServices.GetService(typeof(UserManager<ApplicationUser>));
            // var roleManager = (RoleManager<IdentityRole>)app.ApplicationServices.GetService(typeof(RoleManager<IdentityRole>));            
            // new IdentityInitializer(context,userManager,roleManager);
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {                                                
            AddCustomizedIdentity(serviceCollection);
	        serviceCollection.AddTransient<ITokenService,TokenService>();
	        serviceCollection.AddTransient<IEmailSender,EmailSender>();
            serviceCollection.AddScoped<UserManager<ApplicationUser>>();
            serviceCollection.AddScoped<SignInManager<ApplicationUser>>();
            serviceCollection.AddScoped<RoleManager<IdentityRole>>();
	        serviceCollection.AddScoped<IUserIdentityService,UserIdentityService>();            
            //go to SimplCommerce.WebHost.Extensions.ServiceCollectionExtensions
            //serviceCollection.AddDbContext<StormyDbContext>(options =>
            //{
            //    //Add Options for your db provider
            //})
        }
        private async Task DeveloperLogin(HttpContext httpContext)
        {
            var UserManager = httpContext.RequestServices.GetRequiredService<UserManager<ApplicationUser>>();
            var signInManager = httpContext.RequestServices.GetRequiredService<SignInManager<ApplicationUser>>();

            var _user = await UserManager.FindByNameAsync("a random user");

            await signInManager.SignInAsync(_user, isPersistent: false);
        }
        //TODO: Move this to a extension method, like used on WebHost
        private void AddCustomizedIdentity(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<StormyDbContext>()
                .AddDefaultTokenProviders();   
            var signingConfigurations = new SigningConfigurations();                        
            services.AddSingleton(signingConfigurations);
            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                Container.Configuration.GetSection("Jwt"))
                    .Configure(tokenConfigurations);
            services.Configure<IdentityOptions>(options =>
            {
                //Default Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                //User Settings
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
                //Sign In Settings
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
            services.AddAuthentication(options => options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {                    
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        //TODO: you probably don't need of theses classes:SigningConfigurations and TokenConfigurations
                        ValidateIssuer = true,
                        ValidIssuer = tokenConfigurations.Audience,
                        ValidateAudience = true,
                        ValidAudience = "Anyone",
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = signingConfigurations.Key,
                        RequireExpirationTime = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,                        
                    };                    
                });
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    //?? This is the same thing that on line 61?
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)                    
                    .RequireAuthenticatedUser()
                    .Build());
            });
        }
    }
}
