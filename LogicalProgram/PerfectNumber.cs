using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public static void GerPerfectnumber()
        {
            int n, i, sum,min,max;
            Console.WriteLine("give Starting range or number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give ending range or number");
            max= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("perfect number in the range is:");
            for (n=min;n<=max;n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if(n%i==0)
                    
                        sum += i;
                        i++;
                    
                   
                }
                if(sum==n)
                    Console.WriteLine("{0}",n);
            }
        }
    }
}
