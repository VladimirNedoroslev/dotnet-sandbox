using System.Threading;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    public abstract class WorkerDecorator : IWorker
    {
        private readonly IWorker _worker;

        protected WorkerDecorator(IWorker worker)
        {
            _worker = worker;
        }

        public virtual async Task ProcessJobAsync(CancellationToken cancellationToken)
        {
            await _worker.ProcessJobAsync(cancellationToken);
        }

        public virtual async Task CancelJobAsync(CancellationToken cancellationToken)
        {
            await _worker.CancelJobAsync(cancellationToken);
        }
    }
}