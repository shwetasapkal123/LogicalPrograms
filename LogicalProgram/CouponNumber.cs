using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CouponNumber
    {
        public static void GetCouponNumber()
        {
            int i = 0,dublicate=0;

            int[] coupons = { };

            Random random = new Random();

            while(i<100-10)
            {
                int randomInput = random.Next(10, 100);

                var check = Array.Exists(coupons, x => x == randomInput);
                
                if(check)
                {
                    dublicate += 1;
                }
                else
                {
                    coupons.Append(randomInput);
                    i += 1;
                }
            }
            Console.WriteLine(i+dublicate);

        }
    }
}
