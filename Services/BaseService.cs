using Microsoft.Extensions.Logging;

namespace Demo.MediatR.Services
{
    public class BaseService<T>
    {
        private protected readonly ILogger<T> _logger;
        public BaseService(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }
    }
}
