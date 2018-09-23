using Synchronization.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synchronization.Service
{
    public class UserService
    {
        public UserService(TraceCounter counter)
        {
            this.counter = counter;
        }
        private readonly TraceCounter counter;

        public void CountActivities(int id)
        {
            counter.Count(id);
        }
    }

}
