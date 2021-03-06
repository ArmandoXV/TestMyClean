using System.Threading.Tasks;
using TestMyClean.SharedKernel;

namespace TestMyClean.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}