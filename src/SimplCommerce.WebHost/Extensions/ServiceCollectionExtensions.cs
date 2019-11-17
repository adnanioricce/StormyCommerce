using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Infrastructure.Web.ModelBinders;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Logging;
using StormyCommerce.WebHost.Mappings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace SimplCommerce.WebHost.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private static readonly IModuleConfigurationManager _modulesConfig = new ModuleConfigurationManager();

        public static IServiceCollection AddSingleModule(this IServiceCollection services, string contentRootPath, string moduleId)
        {
            const string moduleManifestName = "module.json";
            var module = _modulesConfig.GetSingleModule(moduleId);
            var moduleFolder = new DirectoryInfo(Path.Combine(contentRootPath, "Modules", module.Id));
            var moduleManifestPath = Path.Combine(moduleFolder.FullName, moduleManifestName);
            if (!File.Exists(moduleManifestPath))
            {
                throw new MissingModuleManifestException($"The manifest for the module '{moduleFolder.Name}' was not found", module.Id);
            }
            if (!module.IsBundledWithHost)
            {
                TryLoadModuleAssembly(moduleFolder.FullName, module);
                if (module.Assembly == null)
                {
                    throw new Exception($"Cannot find main assembly for module {module.Id}");
                }
                else
                {
                    module.Assembly = Assembly.Load(new AssemblyName(moduleFolder.Name));
                }
            }
            GlobalConfiguration.Modules.Add(module);
            RegisterModuleInitializerServices(module, ref services);
            return services;
        }

        public static IServiceCollection AddModules(this IServiceCollection services, string contentRootPath)
        {
            const string moduleManifestName = "module.json";
            var modulesFolder = Path.Combine(contentRootPath, "Modules");
            foreach (var module in _modulesConfig.GetModules())
            {
                var moduleFolder = new DirectoryInfo(Path.Combine(modulesFolder, module.Id));
                var moduleManifestPath = Path.Combine(moduleFolder.FullName, moduleManifestName);
                if (!File.Exists(moduleManifestPath))
                {
                    throw new MissingModuleManifestException($"The manifest for the module '{moduleFolder.Name}' is not found.", moduleFolder.Name);
                }

                using (var reader = new StreamReader(moduleManifestPath))
                {
                    string content = reader.ReadToEnd();
                    dynamic moduleMetadata = JsonConvert.DeserializeObject(content);
                    module.Name = moduleMetadata.name;
                    module.IsBundledWithHost = moduleMetadata.isBundledWithHost;
                }

                if (!module.IsBundledWithHost)
                {
                    TryLoadModuleAssembly(moduleFolder.FullName, module);
                    if (module.Assembly == null)
                    {
                        throw new Exception($"Cannot find main assembly for module {module.Id}");
                    }
                }
                else
                {
                    module.Assembly = Assembly.Load(new AssemblyName(moduleFolder.Name));
                }

                GlobalConfiguration.Modules.Add(module);
                RegisterModuleInitializerServices(module, ref services);
            }

            return services;
        }        

        /// <summary>
        /// localize ModelBinding messages, e.g. when user enters string value instead of number...
        /// these messages can't be localized like data attributes
        /// </summary>
        /// <param name="mvc"></param>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IMvcBuilder AddModelBindingMessagesLocalizer
            (this IMvcBuilder mvc, IServiceCollection services)
        {
            return mvc.AddMvcOptions(o =>
            {
                var factory = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
                var L = factory.Create(null);

                o.ModelBindingMessageProvider.SetValueIsInvalidAccessor((x) => L["The value '{0}' is invalid.", x]);
                o.ModelBindingMessageProvider.SetValueMustBeANumberAccessor((x) => L["The field {0} must be a number.", x]);
                o.ModelBindingMessageProvider.SetMissingBindRequiredValueAccessor((x) => L["A value for the '{0}' property was not provided.", x]);
                o.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor((x, y) => L["The value '{0}' is not valid for {1}.", x, y]);
                o.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => L["A value is required."]);
                o.ModelBindingMessageProvider.SetMissingRequestBodyRequiredValueAccessor(() => L["A non-empty request body is required."]);
                o.ModelBindingMessageProvider.SetNonPropertyAttemptedValueIsInvalidAccessor((x) => L["The value '{0}' is not valid.", x]);
                o.ModelBindingMessageProvider.SetNonPropertyUnknownValueIsInvalidAccessor(() => L["The value provided is invalid."]);
                o.ModelBindingMessageProvider.SetNonPropertyValueMustBeANumberAccessor(() => L["The field must be a number."]);
                o.ModelBindingMessageProvider.SetUnknownValueIsInvalidAccessor((x) => L["The supplied value is invalid for {0}.", x]);
                o.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor((x) => L["Null value is invalid."]);
            });
        }

        private static void AddApplicationPart(IMvcBuilder mvcBuilder, Assembly assembly)
        {
            var partFactory = ApplicationPartFactory.GetApplicationPartFactory(assembly);
            foreach (var part in partFactory.GetApplicationParts(assembly))
            {
                mvcBuilder.PartManager.ApplicationParts.Add(part);
            }

            var relatedAssemblies = RelatedAssemblyAttribute.GetRelatedAssemblies(assembly, throwOnError: false);
            foreach (var relatedAssembly in relatedAssemblies)
            {
                partFactory = ApplicationPartFactory.GetApplicationPartFactory(relatedAssembly);
                foreach (var part in partFactory.GetApplicationParts(relatedAssembly))
                {
                    mvcBuilder.PartManager.ApplicationParts.Add(part);
                }
            }
        }                
        public static IServiceCollection AddStormyDataStore(this IServiceCollection services, IConfiguration configuration)
        {            
            services.AddDbContextPool<StormyDbContext>(options => {
                options.UseLazyLoadingProxies();
                options.UseLoggerFactory(Container.loggerFactory);
                options.UseSqlServer(configuration.GetConnectionString("LocalDb"), b => b.MigrationsAssembly("SimplCommerce.WebHost"));                
                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            });
            return services;
        }
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            var config = new MapperConfiguration(mc => {
                mc.AddProfile(new CatalogProfile());
                mc.AddProfile(new CustomerProfile());
                mc.AddProfile(new ShippingProfile());
                mc.AddProfile(new PagarMeMapping());
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        } 
        private static void TryLoadModuleAssembly(string moduleFolderPath, ModuleInfo module)
        {
            const string binariesFolderName = "bin";
            var binariesFolderPath = Path.Combine(moduleFolderPath, binariesFolderName);
            var binariesFolder = new DirectoryInfo(binariesFolderPath);

            if (Directory.Exists(binariesFolderPath))
            {
                foreach (var file in binariesFolder.GetFileSystemInfos("*.dll", SearchOption.AllDirectories))
                {
                    Assembly assembly;
                    try
                    {
                        assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file.FullName);
                    }
                    catch (FileLoadException)
                    {
                        // Get loaded assembly. This assembly might be loaded
                        assembly = Assembly.Load(new AssemblyName(Path.GetFileNameWithoutExtension(file.Name)));

                        if (assembly == null)
                        {
                            throw;
                        }

                        string loadedAssemblyVersion = FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
                        string tryToLoadAssemblyVersion = FileVersionInfo.GetVersionInfo(file.FullName).FileVersion;

                        // Or log the exception somewhere and don't add the module to list so that it will not be initialized
                        if (tryToLoadAssemblyVersion != loadedAssemblyVersion)
                        {
                            throw new Exception($"Cannot load {file.FullName} {tryToLoadAssemblyVersion} because {assembly.Location} {loadedAssemblyVersion} has been loaded");
                        }
                    }

                    if (Path.GetFileNameWithoutExtension(assembly.ManifestModule.Name) == module.Id)
                    {
                        module.Assembly = assembly;
                    }
                }
            }
        }
        public static void AddSampleData(this StormyDbContext dbContext)
        {
            
        }
        private static void RegisterModuleInitializerServices(ModuleInfo module, ref IServiceCollection services)
        {
            var moduleInitializerType = module.Assembly.GetTypes()
                    .FirstOrDefault(t => typeof(IModuleInitializer).IsAssignableFrom(t));
            if ((moduleInitializerType != null) && (moduleInitializerType != typeof(IModuleInitializer)))
            {
                services.AddSingleton(typeof(IModuleInitializer), moduleInitializerType);
            }
        }

        private static Task HandleRemoteLoginFailure(RemoteFailureContext ctx)
        {
            ctx.Response.Redirect("/login");
            ctx.HandleResponse();
            return Task.CompletedTask;
        }
    }
}
