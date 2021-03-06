using System.Threading.Tasks;
using TestMyClean.SharedKernel;
using TestMyClean.SharedKernel.Interfaces;

namespace TestMyClean.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
