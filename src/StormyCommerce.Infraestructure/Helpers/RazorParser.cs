using System.Reflection;

namespace StormyCommerce.Infraestructure.Helpers
{
    public class RazorParser
    {
        private Assembly assembly;

        public RazorParser(Assembly _assembly)
        {
            assembly = _assembly;
        }

        //public string UsingTemplateFromEmbedded<T>(string path,T model)
        //{
        //    string template = EmbeddedResourceHelper.GetResourceAsString(assembly,GenerateFileAssemblyPath(path,assembly));
        //    var result = Parse(template,model);
        //    return result;
        //}
        //public string Parse<T>(string template,T model)
        //{
        //    return ParseAsync(template,model).GetAwaiter().GetResult();
        //}
        //async Task<string> ParseAsync<T>(string template,T model)
        //{
        //    var engine = new RazorLightEngineBuilder()
        //    .UseEmbeddedResourcesProject(typeof(InMemoryRazorLightProject))
        //    .UseMemoryCachingProvider()
        //    .Build();

        //    return await engine.CompileRenderAsync<T>(Guid.NewGuid().ToString(),template,model);
        //}
        private string GenerateFileAssemblyPath(string template, Assembly assembly)
        {
            string assemblyName = assembly.GetName().Name;
            return string.Format($"{assemblyName}.{template}.cshtml");
        }
    }
}
