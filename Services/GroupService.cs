using Demo.MediatR.Infrastructures.Events.Internal;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Demo.MediatR.Services
{
    public class GroupService : BaseService<GroupService>, IGroupService
    {
        private readonly INotifierMediatorService _notifierMediatorService;
        public GroupService(INotifierMediatorService notifierMediatorService,
                                ILoggerFactory loggerFactory) : base(loggerFactory)
        {
            _notifierMediatorService = notifierMediatorService;
        }

        public async Task JoinAsync(bool isNew)
        {
            var @event = new NewMemberEvent { NotifyText = isNew.ToString() };

            _logger.LogInformation("Publish new event {@NewMemberEvent} ...", @event);
            _notifierMediatorService.Notify(@event);

            // Do something here
            _logger.LogInformation("Event published successfully. ===> {@NewMemberEvent}", @event);
        }
    }
}
