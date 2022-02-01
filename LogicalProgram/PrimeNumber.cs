using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        
        public void FindPrime()
        {
            Console.WriteLine("Enter number to check prime");
            int n=Convert.ToInt32(Console.ReadLine());
            bool prime = true;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    prime=false;
                }
            }
            if (prime)
                Console.WriteLine("{0} is Prime Number", n);
            else
                Console.WriteLine("{0} is not Prime Number",n);
        }
    }
}
