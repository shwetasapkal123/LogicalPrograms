using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
     class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch watch = new Stopwatch();
            //FibonocciSeries.findfibonoceiSeries();

           // PerfectNumber.GerPerfectnumber();

            PrimeNumber prime = new PrimeNumber();           
            prime.FindPrime();

            //ReverseNumber.FindReverseNumber();

            //CouponNumber.GetCouponNumber();

            //WatchStop.StartStopWatch();
            Console.ReadLine();
        }
    }
}
