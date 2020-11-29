using Demo.MediatR.Infrastructures.Events.Internal;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Demo.MediatR.Services
{
    public class NotifierMediatorService : BaseService<NotifierMediatorService>, INotifierMediatorService
    {
        private readonly IMediator _mediator;

        public NotifierMediatorService(IMediator mediator,
                                            ILoggerFactory loggerFactory) : base(loggerFactory)
        {
            _mediator = mediator;
        }

        public void Notify(NewMemberEvent @event)
        {
            _mediator.Publish(@event);
        }
    }
}
