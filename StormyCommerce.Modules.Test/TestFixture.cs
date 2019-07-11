using System;
namespace StormyCommerce.Modules.Test
{
    public class TestFixture<TStartup> : IDisposable where TStartup : class
    {        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
