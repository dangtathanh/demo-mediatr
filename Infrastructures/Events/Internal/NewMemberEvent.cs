using MediatR;

namespace Demo.MediatR.Infrastructures.Events.Internal
{
    public class NewMemberEvent : INotification
    {
        public string NotifyText { get; set; }
    }
}
