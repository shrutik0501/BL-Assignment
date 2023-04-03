using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class PowerOf2
    {
        public static void findPowerOf2(int power) 
        {
            
            int i = 0;
            int p = 1;
            for (int j = 1; j <=power ; j++)
            {
                Console.WriteLine("2 ^" + i + "=" + p);
                p = p * 2;
                i++;
            }
            Console.WriteLine("the power of 2 for " + power + " is: " + p);
        }
    }
}
