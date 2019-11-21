using System.Reflection;

namespace StormyCommerce.Infraestructure.Helpers
{
    public class RazorParser
    {
        private readonly Assembly assembly;

        public RazorParser(Assembly _assembly)
        {
            assembly = _assembly;
        }
        private string GenerateFileAssemblyPath(string template, Assembly assembly)
        {
            string assemblyName = assembly.GetName().Name;
            return string.Format($"{assemblyName}.{template}.cshtml");
        }
    }
}
