using Demo.MediatR.Infrastructures.Events.Internal;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.MediatR.Infrastructures.EventHandlers.Internal
{
    public class NewGroupMemberHandler: BaseEventHandler<NewGroupMemberHandler>, INotificationHandler<NewMemberEvent>
    {
        public NewGroupMemberHandler(ILoggerFactory loggerFactory) : base(loggerFactory)
    {

    }

    public async Task Handle(NewMemberEvent @event, CancellationToken cancellationToken)
    {
        await TrackAsync(@event);
    }

    private async Task TrackAsync(NewMemberEvent @event)
    {
        _logger.LogInformation("Receive new event {@NewMemberEvent} ...", @event);
        await Task.Delay(10000);
        _logger.LogInformation("Event processed {@NewMemberEvent} successfully.", @event);
    }
}
}
