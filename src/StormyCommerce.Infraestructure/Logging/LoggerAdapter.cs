using Microsoft.Extensions.Logging;
using StormyCommerce.Core.Interfaces;

namespace StormyCommerce.Infraestructure.Logging
{
    public class LoggerAdapter<T> : IAppLogger<T> where T : class
    {
        private readonly ILogger<T> logger;

        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<T>();
        }

        public void LogStackTrace(string message, params object[] args)
        {
            logger.LogTrace(message, args);
        }

        public void LogError(string message, params object[] args)
        {
            logger.LogError(message, args);
        }

        public void LogInformation(string message, params object[] args)
        {
            logger.LogInformation(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            logger.LogWarning(message, args);
        }
    }
}
