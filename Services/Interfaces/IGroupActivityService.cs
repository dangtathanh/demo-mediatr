using Demo.MediatR.Infrastructures.Events.Internal;
using System.Threading.Tasks;

namespace Demo.MediatR.Services
{
    public interface IGroupActivityService
    {
        Task TrackAsync(NewMemberEvent @event);
    }
}
