using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class PrimeFactors
    {
        public static void findPrimeFactors()
        {
            Console.WriteLine("enter no");
            double n = Convert.ToDouble(Console.ReadLine());
            int i = 2;
            Console.WriteLine("Prime factors are");
            while (n != 0 && i > 0)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / 2;
                }
                else
                    i++;
            }
        }
    }
}
