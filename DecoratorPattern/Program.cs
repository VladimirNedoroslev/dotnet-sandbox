using System;
using System.Threading.Tasks;
using DecoratorPattern.Decorators;
using DecoratorPattern.Implementations;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Services;

namespace DecoratorPattern
{
    public static class Program
    {
        private static async Task Main()
        {
            var baseWorker = new SimpleWorker();
            var decoratedWorker = new EnhancedSimpleWorker(baseWorker);
            var service = new SomeService(decoratedWorker);
            await service.DoJobAsync();
        }
        
    }
}