using Demo.MediatR.Infrastructures.Events.Internal;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Demo.MediatR.Services
{
    public class GroupService : BaseService<GroupService>, IGroupService
    {
        private readonly IMediator _mediator;
        public GroupService(IMediator mediator,
                                ILoggerFactory loggerFactory) : base(loggerFactory)
        {
            _mediator = mediator;
        }

        public async Task JoinAsync(bool isNew)
        {
            var @event = new NewMemberEvent { NotifyText = isNew.ToString() };

            _logger.LogInformation("Publish new event {@NewMemberEvent} ...", @event);
            _mediator.Publish(@event);

            await Task.Delay(1);
            // Do something here
            _logger.LogInformation("Event published successfully. ===> {@NewMemberEvent}", @event);
        }
    }
}
