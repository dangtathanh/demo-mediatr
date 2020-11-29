using Demo.MediatR.Infrastructures.Events.Internal;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.MediatR.Services
{
    public class GroupActivityService : BaseService<GroupActivityService>, IGroupActivityService, INotificationHandler<NewMemberEvent>
    {
        public GroupActivityService(ILoggerFactory loggerFactory) : base(loggerFactory)
        {

        }

        public async Task Handle(NewMemberEvent @event, CancellationToken cancellationToken)
        {
            await TrackAsync(@event);
        }

        public async Task TrackAsync(NewMemberEvent @event)
        {
            _logger.LogInformation("Receive new event {@NewMemberEvent} ...", @event);
            await Task.Delay(10000);
            _logger.LogInformation("Event processed {@NewMemberEvent} successfully.", @event);
        }
    }
}
