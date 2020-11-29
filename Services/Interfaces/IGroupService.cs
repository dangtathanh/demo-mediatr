using System.Threading.Tasks;

namespace Demo.MediatR.Services
{
    public interface IGroupService
    {
        Task JoinAsync(bool isNew);
    }
}
