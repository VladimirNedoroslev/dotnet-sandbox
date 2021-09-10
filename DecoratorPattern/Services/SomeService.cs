using System.Threading;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Services
{
    public class SomeService
    {
        private readonly IWorker _worker;

        public SomeService(IWorker worker)
        {
            _worker = worker;
        }

        public async Task DoJobAsync(CancellationToken cancellationToken = default)
        {
            await _worker.ProcessJobAsync(cancellationToken);
        }
    }
}