using System.Threading.Tasks;
using TestMyClean.SharedKernel;

namespace TestMyClean.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}