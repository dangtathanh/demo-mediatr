using Demo.MediatR.Infrastructures.Events.Internal;

namespace Demo.MediatR.Services
{
    public interface INotifierMediatorService
    {
        void Notify(NewMemberEvent @event);
    }
}
