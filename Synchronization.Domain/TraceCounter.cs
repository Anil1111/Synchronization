using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Synchronization.Domain
{
    public class TraceCounter
    {
        private readonly SpecificContext context;

        public TraceCounter(SpecificContext context) => this.context = context;

        public async Task<uint> Count(int id)
        {
            uint cnt = 0;
            var activities = await context.CountInteractions(id).ConfigureAwait(false);
            if (activities != null && activities.Any())
            {
                cnt += (uint)activities.Count();
            }
            Console.WriteLine(cnt);
            return cnt;
        }
        public async Task<uint> CountTotal(int[] ids)
        {
            uint total = 0;
            foreach (var item in ids)
            {
                total += await Count(item);
            }
            Console.WriteLine(total);
            return total;
        }
    }

    public class SpecificContext
    {
        public async Task<IEnumerable<int>> CountInteractions(int id)
        {
            var ret = new List<int>();

            for (int i = 0; i < id + 10; i++)
            {
                ret.Add(i);
            }

            return ret;
        }
    }
}
