using System;
using System.Threading;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Implementations
{
    public class SimpleWorker : IWorker
    {
        private readonly TimeSpan _processingJobTime = TimeSpan.FromSeconds(1);
        private readonly TimeSpan _cancelingJobTime = TimeSpan.FromSeconds(2);
        
        public async Task ProcessJobAsync(CancellationToken cancellationToken = default)
        {
            Console.WriteLine($"I'm doing some simple work, finish in {_processingJobTime.Seconds} seconds");
            await Task.Delay(_processingJobTime, cancellationToken);
            Console.WriteLine("Simple work has been finished");
        }

        public async Task CancelJobAsync(CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Trying to cancel job in a simple way");
            await Task.Delay(_cancelingJobTime, cancellationToken);
            Console.WriteLine("Job has been cancelled in a simple way");
        }
    }
}