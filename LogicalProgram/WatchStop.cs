using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class WatchStop
    {
        public static void StartStopWatch()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            watch.Stop();
            Console.WriteLine("Elapsed Time:"+watch.ElapsedMilliseconds);
            var start = DateTime.Today;
            Console.WriteLine("start time:"+ start);
            var end = DateTime.Today;
            Console.WriteLine("start Time:"+ end);
            Console.WriteLine("Elapsed time:"+(end-start));
        }
        
    }
}
