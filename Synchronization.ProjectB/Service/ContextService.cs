using Synchronization.Domain;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Synchronization.ProjectB.Service
{
    public class ContextService
    {
        public ContextService(TraceCounter counter)
        {
            this.counter = counter;
        }
        private readonly TraceCounter counter;

        public uint CountActivities(int id)
        {
            return  counter.Count(id).Result;
        }

        public uint CountTotal(int[] ids)
        {
            return counter.CountTotal(ids).Result;
        }
    }
}
