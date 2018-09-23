using Synchronization.Domain;
using Synchronization.Service;
using System;
using System.Threading.Tasks;

namespace Synchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] list = new Task[10];
            int i = 0;
            list[i] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(1));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(2));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(3));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(4));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(5));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(6));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(7));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(8));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(9));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(10));
            list[i++] = Task.Factory.StartNew(() => new UserService(new TraceCounter(new SpecificContext())).CountActivities(0));

            Task.WaitAll(list);

            Console.ReadKey();
        }
    }


    
}
