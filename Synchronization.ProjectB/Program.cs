using Synchronization.Domain;
using Synchronization.ProjectB.Service;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Synchronization.ProjectB
{
    class Program
    {
        static readonly ContextService context = new ContextService(new TraceCounter(new SpecificContext()));
        static void Main(string[] args)
        {

            Task.Factory.StartNew(() => context.CountTotal(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            /** The asynchronised calls **/
            //Task[] list = new Task[10];
            //int i = 0;
            //list[i] = Task.Factory.StartNew(() => { context.CountActivities(0); });
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(1));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(2));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(3));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(4));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(5));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(6));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(7));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(8));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(9));
            //list[i++] = Task.Factory.StartNew(() => context.CountActivities(10));
            //Task.WaitAll(list);

            /** The synchronised calls **/

            //context.CountActivities(1);
            //context.CountActivities(2);
            //context.CountActivities(3);
            //context.CountActivities(4);
            //context.CountActivities(5);
            //context.CountActivities(6);
            //context.CountActivities(7);
            //context.CountActivities(8);
            //context.CountActivities(9);
            //context.CountActivities(10);
            //context.CountActivities(0);

            Console.ReadKey();

        }
    }
}
