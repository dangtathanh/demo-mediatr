using Microsoft.Extensions.Logging;

namespace Demo.MediatR.Infrastructures.EventHandlers.Internal
{
    public class BaseEventHandler<T>
    {
        private protected readonly ILogger<T> _logger;
        public BaseEventHandler(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }
    }
}
