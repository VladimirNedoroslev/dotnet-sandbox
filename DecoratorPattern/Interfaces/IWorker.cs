using System.Threading;
using System.Threading.Tasks;

namespace DecoratorPattern.Interfaces
{
    public interface IWorker
    {
        Task ProcessJobAsync(CancellationToken cancellationToken = default);

        Task CancelJobAsync(CancellationToken cancellationToken = default);
    }
}