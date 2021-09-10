using System;
using System.Threading;
using System.Threading.Tasks;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    public class EnhancedSimpleWorker : WorkerDecorator
    {
        private readonly TimeSpan _processingJobTime = TimeSpan.FromMilliseconds(500);
        private readonly TimeSpan _cancelingJobTime = TimeSpan.FromSeconds(1);
        
        public EnhancedSimpleWorker(IWorker worker) : base(worker)
        {
        }

        public override async Task ProcessJobAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("I'm doing some simple work but I'm enhanced," +
                              $" finish in {_processingJobTime.Milliseconds} milliseconds");
            await Task.Delay(_processingJobTime, cancellationToken);
            Console.WriteLine("Finished simple work with enhancements");
        }

        public override async Task CancelJobAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Trying to cancel job in a simple way but I'm enhanced");
            await Task.Delay(_cancelingJobTime, cancellationToken);
            Console.WriteLine("Job has been cancelled in a simple way with enhancments");
        }
    }
}